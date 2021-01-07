using BLL.Entities;
using BLL.DTO1;
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
        List<DoctorDTO> GetConnectedSpecializations();
        List<DoctorDTO> GetDoctorsList();
    }
}
