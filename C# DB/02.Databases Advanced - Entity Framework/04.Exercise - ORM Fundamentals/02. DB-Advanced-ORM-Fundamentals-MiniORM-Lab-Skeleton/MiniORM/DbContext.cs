using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace MiniORM
{
	public class DbContext
	{
		private readonly DatabaseConnection connection;
		private readonly Dictionary<Type, PropertyInfo> dbSetProperties;
		internal static readonly Type[] AllowedSqlTypes =
		{
			typeof(string),
			typeof(int),
			typeof(uint),
			typeof(long),
			typeof(ulong),
			typeof(decimal),
			typeof(bool),
			typeof(DateTime)
		};

		public DbContext(string connectionString)
		{
			this.connection = new DatabaseConnection(connectionString);
			this.dbSetProperties = this.DiscoverDbSet();

			using (new ConnectionManager(connection))
			{
				this.InitializeDbSet();
			}

			this.MapAllRelations();
		}

		public void SaveChanges()
		{
			var dbSets = this.dbSetProperties
				.Select(p => p.Value.GetValue(this))
				.ToArray();

			foreach (IEnumerable<object> dbSet in dbSets)
			{
				var invalidEntities = dbSet.
					Where(e => !IsObjectValid(e))
					.ToArray();

				if (invalidEntities.Any())
				{
					throw new InvalidOperationException($"{invalidEntities.Length} Invalid Entities found in {dbSet.GetType().Name}!");
				}
			}

			using (new ConnectionManager(connection))
			{
				using (var transaction = connection.StartTransaction())
				{
					foreach (IEnumerable dbSet in dbSets)
					{
						var type = dbSet.GetType().GetGenericArguments().First();

						var persistMethod = typeof(DbContext)
							.GetMethod("Persist", BindingFlags.Instance | BindingFlags.NonPublic)
							.MakeGenericMethod();

						try
						{
							persistMethod.Invoke(this, new object[] { dbSet });
						}
						catch (TargetInvocationException e)
						{
							throw e.InnerException;
						}
						catch (InvalidOperationException e) 
						{
							transaction.Rollback();
							throw;
						}
						catch (SqlException e)
						{
							transaction.Rollback();
							throw;
						}
					}

					transaction.Commit();
				}
			}
		}

		private void Persist<TEntity>(DbSet<TEntity> dbSet)
			where TEntity: class, new()
		{
			var tableName = GetTableName(typeof(TEntity));
			var columns = this.connection.FetchColumnNames(tableName).ToArray();

			if (dbSet.ChangeTracker.Added.Any())
			{
				this.connection.InsertEntities(dbSet.ChangeTracker.Added, tableName, columns);
			}

			var modifiedEntities = dbSet.ChangeTracker.GetModifiedEntities(dbSet).ToArray();

			if (modifiedEntities.Any())
			{
				this.connection.UpdateEntities(modifiedEntities, tableName, columns);
			}

			if (dbSet.ChangeTracker.Removed.Any())
			{
				this.connection.DeleteEntities(dbSet.ChangeTracker.Removed, tableName, columns);
			}
		}

		private void PopulateDbSet<TEntity>(PropertyInfo dbSet)
			where TEntity: class, new()
		{
			var entities = LoadTableEntities<TEntity>().ToArray();
			var dbSetInstance = new DbSet<TEntity>(entities);

			ReflectionHelper.ReplaceBackingField(this, dbSet.Name, dbSetInstance);
		}

		private void MapAllRelations()
		{
			foreach (var property in this.dbSetProperties)
			{
				var type = property.Key;

				var mapRelationsGeneric = typeof(DbContext)
					.GetMethod("MapRelations", BindingFlags.Instance | BindingFlags.NonPublic)
					.MakeGenericMethod(type);

				var dbSet = property.Value.GetValue(this);

				mapRelationsGeneric.Invoke(this, new object[] { dbSet });
			}
		}

		private void MapRelations<TEntity>(DbSet<TEntity> dbSet)
			where TEntity: class, new()
		{
			var type = typeof(TEntity);

			MapNavigationProperties(dbSet);

			var collections = type
				.GetProperties()
				.Where(p => p.PropertyType.IsGenericType
				&& p.PropertyType.GetGenericTypeDefinition() == typeof(ICollection))
				.ToArray();

			foreach (var collection in collections)
			{
				var collectionType = collection.PropertyType.GenericTypeArguments.First();

				var mapCollectionMethod = typeof(DbContext)
					.GetMethod("MapRelations", BindingFlags.Instance | BindingFlags.NonPublic)
					.MakeGenericMethod(type, collectionType);

				mapCollectionMethod.Invoke(this, new object[] { dbSet, collection });
			}
		}

		private void MapRelations<TDbSet, TCollection>(DbSet<TDbSet> dbSet, PropertyInfo collectionProperty)
			where TDbSet: class, new() where TCollection: class, new()
		{
			var entityType = typeof(TDbSet);
			var collectionType = typeof(TCollection);

			var primaryKeys = collectionType.
				GetProperties()
				.Where(p => p.HasAttribute<KeyAttribute>())
				.ToArray();

			var primaryKey = primaryKeys.First();
			var foreignKey = entityType.GetProperties()
				.First(p => p.HasAttribute<KeyAttribute>());

			var isManyToManyRelation = primaryKeys.Length >= 2;
			if (isManyToManyRelation)
			{
				primaryKey = collectionType.GetProperties()
					.First(p => collectionType
							.GetProperty(p.GetCustomAttribute<ForeignKeyAttribute>().Name)
							.PropertyType == entityType);
			}

			var navigationDbSet = (DbSet<TCollection>)this.dbSetProperties[collectionType]
				.GetValue(this);

			foreach (var entity in dbSet)
			{
				var primaryKeyValue = foreignKey.GetValue(entity);
				var navigationEntities = navigationDbSet
					.Where(navigationEntity => 
						primaryKey.GetValue(navigationEntity).Equals(primaryKeyValue));

				ReflectionHelper.ReplaceBackingField(entity, collectionProperty.Name, navigationEntities);
			}
		}

		private void MapNavigationProperties<TEntity>(DbSet<TEntity> dbSet) 
			where TEntity : class, new()
		{
			var entityType = typeof(TEntity);

			var foreignKeys = entityType.GetProperties()
				.Where(pi => pi.HasAttribute<KeyAttribute>())
				.ToArray();

			foreach (var foreignKey in foreignKeys)
			{
				var navigationPropertyName = foreignKey.GetCustomAttribute<ForeignKeyAttribute>().Name;
				var navigationProperty = entityType.GetProperty(navigationPropertyName);

				var navigationDbSet = this.dbSetProperties[navigationProperty.PropertyType].GetValue(this);
				var navigationPrimaryKey = navigationProperty.PropertyType.GetProperties()
					.First(pi => pi.HasAttribute<KeyAttribute>());

				foreach (var entity in dbSet)
				{
					var foreignKeyValue = foreignKey.GetValue(entity);
					var navigationPropertyValue = ((IEnumerable<object>)navigationDbSet)
						.First(currentNavigationProperty => navigationPrimaryKey
						.GetValue(currentNavigationProperty).Equals(foreignKeyValue));

					navigationProperty.SetValue(entity, navigationPropertyValue);
				}
			}
		}

		private IEnumerable<TEntity> LoadTableEntities<TEntity>() 
			where TEntity : class, new()
		{
			var table = typeof(TEntity);
			var columns = GetEntityColumnNames(table);
			var tableName = GetTableName(table);

			var fetchedRows = this.connection.FetchResultSet<TEntity>(tableName, columns).ToArray();
			return fetchedRows;
		}

		private string[] GetEntityColumnNames(Type table)
		{
			var tableName = this.GetTableName(table);
			var dbColumns = this.connection.FetchColumnNames(tableName);

			var columns = table.GetProperties()
				.Where(pi => dbColumns.Contains(pi.Name) &&
					  !pi.HasAttribute<NotMappedAttribute>() &&
					  AllowedSqlTypes.Contains(pi.PropertyType))
				.Select(pi => pi.Name)
				.ToArray();
			return columns;
		}

		private string GetTableName(Type type)
		{
			var tableName = ((TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute)))?.Name;

			if (tableName == null) 
			{
				tableName = this.dbSetProperties[type].Name;
			}

			return tableName;
		}

		private bool IsObjectValid(object e)
		{
			var validationContext = new ValidationContext(e);
			var validationErrors = new List<ValidationResult>();

			var validationResult = Validator.TryValidateObject(e, validationContext, validationErrors, true);
			return validationResult;
		}

		private void InitializeDbSet()
		{
			foreach (var property in this.dbSetProperties)
			{
				var setType = property.Key;
				var setProperty = property.Value;

				var populateDbSetGeneric = typeof(DbContext)
					.GetMethod("PopulateDbSet", BindingFlags.Instance | BindingFlags.NonPublic)
					.MakeGenericMethod(setType);

				populateDbSetGeneric.Invoke(this, new object[] { setProperty });
			}
		}

		private Dictionary<Type, PropertyInfo> DiscoverDbSet()
		{
			var dbSets = this.GetType()
				.GetProperties()
				.Where(pi => pi.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
				.ToDictionary(pi => pi.PropertyType.GetGenericArguments().First(), pi => pi);

			return dbSets;
		}
	}
}