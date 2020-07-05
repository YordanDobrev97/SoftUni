using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;
using System.Reflection;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
        {

        }

        public StudentSystemContext(DbContextOptions options)
            : base (options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Homework> HomeworkSubmissions { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder bulder)
        {
            if (!bulder.IsConfigured)
            {
                bulder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=StudentSystem;Integrated Security=True;");
            }

            base.OnConfiguring(bulder);
        }

        protected override void OnModelCreating(ModelBuilder bulder)
        {
            bulder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.StudentId });
            });

            bulder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}