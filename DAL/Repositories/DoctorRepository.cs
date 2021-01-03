using BLL.Interfaces;
using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<string> GetDoctorsNames()
        {
            var visits = context.Visits;
            var doctors = context.Doctors;
            var doctornames = from x in visits
                              join t in doctors on x.DoctorId equals t.DoctorId
                              select t.Name;
            var names = doctornames.ToList();
            return names;
        }
        
        public List<string> GetDoctorsSurnames()
        {
            var visits = context.Visits;
            var doctors = context.Doctors;
            var doctornames = from x in visits
                              join t in doctors on x.DoctorId equals t.DoctorId
                              select t.Surname ;
            var Surname = doctornames.ToList();
            return Surname;
        }

        public List<string> GetConnectedSpecializations()
        {
            var specializatons = context.Specializations;
            var allDoctors = context.Doctors;
            var _Specs = from d in allDoctors
                         join t in specializatons on d.SpecializationId equals t.SpecializationId
                         select t.Name;

            var specsNames = _Specs.ToList();

            return specsNames;
        }
    }
}
