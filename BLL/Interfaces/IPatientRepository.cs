using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetPatients();
        List<string> GetPatientsSurnames();
        List<string> GetPatientsNames();
        void AddPatient(Patient patient);

    }
}
