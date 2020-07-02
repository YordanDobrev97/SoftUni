using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext()
        {

        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<PatientMedicament> PatientMedicaments { get; set; }

        public DbSet<Diagnose> Diagnoses { get; set; }

        public DbSet<Visitation> Visitations { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SoftUni;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder bulder)
        {
            bulder.Entity<PatientMedicament>()
                .HasKey(pm => new { pm.PatientId, pm.MedicamentId });

            bulder.Entity<Patient>(patient =>
            {
                patient
                    .Property(p => p.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(true);

                patient
                    .Property(p => p.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(true);

                patient
                    .Property(p => p.Address)
                    .HasMaxLength(250)
                    .IsUnicode();

                patient
                    .Property(p => p.Email)
                    .HasMaxLength(80);
            });

            bulder.Entity<Visitation>(visitation =>
            {
                visitation
                    .Property(v => v.Comments)
                    .HasMaxLength(250)
                    .IsUnicode();

                visitation
                    .HasOne(v => v.Patient)
                    .WithMany(v => v.Visitations)
                    .HasForeignKey(v => v.PatientId);

                visitation
                    .HasOne(d => d.Doctor)
                    .WithMany(d => d.Visitations)
                    .HasForeignKey(d => d.DoctorId);
            });

            bulder.Entity<Diagnose>(diagnose =>
            {
                diagnose
                    .Property(d => d.Name)
                    .HasMaxLength(50)
                    .IsUnicode();

                diagnose
                    .Property(d => d.Comments)
                    .HasMaxLength(250)
                    .IsUnicode();
            });

            bulder.Entity<Medicament>()
                .Property(m => m.Name)
                .HasMaxLength(50)
                .IsUnicode();
        }
    }
}