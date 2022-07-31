using DoctorAppointment_MVC_EFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment_MVC_EFCore.Controllers
{
    public class AppointmentController : Controller
    {
        DoctorAppointmentDbContext _dbContext ;

        public AppointmentController(DoctorAppointmentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {

            List<Appointment> appointments = _dbContext.Appointments.ToList();
            foreach (var item in appointments)
            {
                Patient p = _dbContext.Patients.Find(item.PatientId);
                item.Patient = p;

            }

            return View(appointments);
        }

        [HttpGet]
        public IActionResult MakeAppointment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MakeAppointment(Appointment appointment)
        {

            _dbContext.Appointments.Add(appointment);
            _dbContext.SaveChanges();
          
            return View();
        }
    }
}
