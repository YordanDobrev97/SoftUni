﻿namespace PetStore.Data
{
    using Microsoft.EntityFrameworkCore;
    using PetStore.Common;
    using PetStore.Models;

    public class PetStoreDbContext : DbContext
    {
        public PetStoreDbContext()
        {
        }

        public PetStoreDbContext(DbContextOptions options)
            : base (options)
        {
        }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<OwnerPets> OwnerPets { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Toy> Toys { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(Constants.ConnectionString);
            }

            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OwnerPets>().HasKey(op => new { op.OwnerId, op.PetId });
        }
    }
}