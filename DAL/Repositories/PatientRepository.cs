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
    }
}
