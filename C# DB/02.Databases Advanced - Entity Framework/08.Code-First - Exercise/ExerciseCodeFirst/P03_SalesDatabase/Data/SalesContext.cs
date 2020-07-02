using Microsoft.EntityFrameworkCore;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase.Data
{
    public class SalesContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SaleDb;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder bulder)
        {
            bulder.Entity<Product>()
                .Property(p => p.Name)
                .HasMaxLength(50)
                .IsUnicode();

            bulder.Entity<Customer>(customer =>
            {
                customer
                    .Property(c => c.Name)
                    .HasMaxLength(100)
                    .IsUnicode();

                customer
                    .Property(c => c.Email)
                    .HasMaxLength(80)
                    .IsUnicode();
            });

            bulder.Entity<Store>()
                .Property(s => s.Name)
                .HasMaxLength(80)
                .IsUnicode();
        }
    }
}
