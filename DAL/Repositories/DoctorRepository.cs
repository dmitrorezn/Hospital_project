using BLL.Interfaces;
using BLL.Entities;
using BLL.DTO1;
using BLL;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private HContext context;

        public DoctorRepository(HContext arg)
        {
            context = arg;
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return context.Doctors;
        }

        public IEnumerable<Doctor> GetDoctorsBySpecialization(int id)
        {
            return context.Doctors.Where(x => x.SpecializationId == id);
        }

        public List<DoctorDTO> GetDoctorsList()
        {
            List<DoctorDTO> doctorsDtoList = new List<DoctorDTO>();
            var visits = context.Visits;
            var doctors = context.Doctors;
            var doctorsDto = from x in visits
                             join t in doctors on x.DoctorId equals t.DoctorId
                             select new { t.DoctorId, t.DName, t.DSurname };

            foreach(var item in doctorsDto)
            {
                doctorsDtoList.Add(new DoctorDTO {
                    DoctorId = item.DoctorId,
                    Name = item.DName,
                    Surname = item.DSurname,
                    Specization = "",
                });
            }

            return doctorsDtoList;
        }

        public List<DoctorDTO> GetConnectedSpecializations()
        {
            List<DoctorDTO> doctorsDtoList = new List<DoctorDTO>();

            var specializatons = context.Specializations;
            var allDoctors = context.Doctors;
            var doctorsDto = from d in allDoctors
                         join t in specializatons on d.SpecializationId equals t.SpecializationId
                         select new { d.DoctorId, d.DName, d.DSurname, t.Name };

            foreach (var item in doctorsDto)
            {
                doctorsDtoList.Add(new DoctorDTO {
                    DoctorId = item.DoctorId,
                    Name = item.DName,
                    Surname = item.DSurname,
                    Specization = item.Name,
                });
            }

            return doctorsDtoList;
        }
    }
}
