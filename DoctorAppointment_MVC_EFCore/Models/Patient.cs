namespace DoctorAppointment_MVC_EFCore.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Mobile { get; set; }
    }
}
