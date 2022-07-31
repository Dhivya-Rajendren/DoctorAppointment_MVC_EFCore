using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment_MVC_EFCore.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
        [DataType(DataType.Time)]
        public DateTime AppointmentTime { get; set; }
        public string AppointmentStatus { get; set; }
    }
}
