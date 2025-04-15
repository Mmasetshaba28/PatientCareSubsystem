using Microsoft.EntityFrameworkCore;
using PatientCareSubsystem.Models;

namespace PatientCareSubsystem.Data
{
    public class PatientCareDbContext: DbContext
    {
        public PatientCareDbContext(DbContextOptions<PatientCareDbContext> options): base(options) { }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<Vital> Vital { get; set; }
        public DbSet<Treatment> Treatment { get; set; }
        public DbSet<Medication> Medication { get; set; }
        public DbSet<DoctorInstruction> DoctorInstruction { get; set; }
    }
}
