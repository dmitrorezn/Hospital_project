using BLL;
using DAL;
using BLL.Interfaces;
using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private HContext context;

        public PatientRepository(HContext arg)
        {
            context = arg;
        }

        public void AddPatient(Patient patient)
        {
            context.Patients.Add(patient);
            context.SaveChanges();
        }

        public IEnumerable<Patient> GetPatients()
        {
            return context.Patients;
        }

        public List<string> GetPatientsSurnames()
        {
            var visits = context.Visits;
            var patients = context.Patients;
            var patientsurnames = from x in visits
                                  join t in patients on x.PatientId equals t.PatientId
                                  select t.Surname;
            var list = patientsurnames.ToList();
            return list;
        }

        public List<string> GetPatientsNames() 
        {
            var visits = context.Visits;
            var patients = context.Patients;
            var patientnames = from x in visits
                               join t in patients on x.PatientId equals t.PatientId
                               select t.Name;
            var names = patientnames.ToList();
            return names;
        }
    }
}
