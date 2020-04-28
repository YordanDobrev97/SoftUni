using DemoTesting.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoTesting.Data
{
    public class SystemDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=SystemDB;Integrated Security=true";

        public DbSet<User> Users { get; set; }

        public DbSet<Topic> Topics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
