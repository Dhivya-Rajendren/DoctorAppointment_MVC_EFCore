namespace DoctorAppointment_MVC_EFCore.Models
{
    public class AppointmentManager
    {
        public Appointment MakeAppointment(Appointment appointment)
        {
            return new Appointment();
        }

        public Appointment GetAppointment(int appointmentId)
        {
            return new Appointment();
        }
    }
}
