using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetDoctors();
        IEnumerable<Doctor> GetDoctorsBySpecialization(int id);
        List<string> GetDoctorsNames();
        List<string> GetDoctorsSurnames();
        List<string> GetConnectedSpecializations();
    }
}
