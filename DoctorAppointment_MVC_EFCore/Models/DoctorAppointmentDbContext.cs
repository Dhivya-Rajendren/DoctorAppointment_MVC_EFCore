using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment_MVC_EFCore.Models
{
    public class DoctorAppointmentDbContext:DbContext
    {
        
        public DoctorAppointmentDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }

    }
}
