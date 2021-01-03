using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private DataManager dataManager;
        public HomeController(DataManager dm)
        {
            dataManager = dm;
        }
        public ActionResult Index()
        {
            VisitsViewModel visitsViewModel = new VisitsViewModel();
            var visits = dataManager.Visits.GetVisits();
            visitsViewModel.Visits = visits;

            var doctornames = dataManager.Doctors.GetDoctorsNames();
            visitsViewModel.DoctorName = doctornames;

            var doctorsurnames = dataManager.Doctors.GetDoctorsSurnames();
            visitsViewModel.DoctorSurname = doctorsurnames;

            var patientnames = dataManager.Patients.GetPatientsNames();
            visitsViewModel.PatientName = patientnames;

            var patientsurnames = dataManager.Patients.GetPatientsSurnames();
            visitsViewModel.PatientSurname = patientsurnames;

            return View(visitsViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}