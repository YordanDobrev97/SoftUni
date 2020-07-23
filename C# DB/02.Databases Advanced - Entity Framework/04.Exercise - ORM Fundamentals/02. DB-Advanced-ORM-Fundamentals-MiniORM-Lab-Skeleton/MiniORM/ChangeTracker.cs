using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MiniORM
{
	public class ChangeTracker<T> where T : class, new()
	{
		private readonly List<T> allEntities;
		private readonly List<T> added;
		private readonly List<T> removed;

		public ChangeTracker(IEnumerable<T> entities)
		{
			this.added = new List<T>();
			this.removed = new List<T>();

			this.allEntities = this.CloneEntities(entities);
		}

		public IReadOnlyCollection<T> AllEntities => this.allEntities.AsReadOnly();

		public IReadOnlyCollection<T> Added => this.added.AsReadOnly();

		public IReadOnlyCollection<T> Removed => this.removed.AsReadOnly();

		public void Add(T element)
		{
			this.added.Add(element);
		}

		public void Remove(T element)
		{
			this.removed.Add(element);
		}

		public IEnumerable<T> GetModifiedEntities(DbSet<T> dbSet)
		{
			var entities = new List<T>();

			var primaryKeyProperties = typeof(T).GetProperties()
				.Where(pi => pi.HasAttribute<KeyAttribute>())
				.ToArray();

			//proxyEntity is old entity
			foreach (var proxyEntity in this.allEntities)
			{
				var primaryKeyValues = GetPrimaryKeyValues(primaryKeyProperties, proxyEntity)
					.ToArray();

				var entity = dbSet.Entities.
					Single(x => GetPrimaryKeyValues(primaryKeyProperties, x).
					SequenceEqual(primaryKeyValues));

				var isModified = IsModified(proxyEntity, entity);

				if (isModified)
				{
					entities.Add(entity);
				}
			}

			return entities;
		}

		private bool IsModified(T proxyEntity, T entity)
		{
			var monitoredProperties = typeof(T).GetProperties()
				.Where(p => DbContext.AllowedSqlTypes.Contains(p.PropertyType));

			var modifieProperties = monitoredProperties.
				Where(p => !Equals(p.GetValue(proxyEntity), p.GetValue(entity)));

			var isModified = modifieProperties.Any();
			return isModified;
		}

		private IEnumerable<object> GetPrimaryKeyValues(IEnumerable<PropertyInfo> primaryKeyProperties, T proxyEntity)
		{
			return primaryKeyProperties.Select(p => p.GetValue(proxyEntity));
		}

		private List<T> CloneEntities(IEnumerable<T> entities)
		{
			var clonedEntities = new List<T>();

			var clonedProperties = typeof(T).GetProperties()
				.Where(x => DbContext.AllowedSqlTypes.Contains(x.PropertyType));

			foreach (var entity in entities)
			{
				var currentEntity = Activator.CreateInstance<T>();

				foreach (var property in clonedProperties)
				{
					var value = property.GetValue(entity);
					property.SetValue(currentEntity, value);
				}

				clonedEntities.Add(currentEntity);
			}

			return clonedEntities;
		}
	}
}