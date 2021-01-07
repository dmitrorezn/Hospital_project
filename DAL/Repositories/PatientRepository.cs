using BLL;
using DAL;
using BLL.Interfaces;
using BLL.Entities;
using BLL.DTO1;
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

        public List<DocsPatientsDTO> GetDocsPatientsDTO()
        {
            List<DocsPatientsDTO> docPatList = new List<DocsPatientsDTO>();
            try
            {
                var visits = context.Visits;
                var patients = context.Patients;
                var doctors = context.Doctors;

                var dto = from x in visits
                           join t in patients on x.PatientId equals t.PatientId
                           join d in doctors on x.DoctorId equals d.DoctorId
                           select new { t.Name, t.Surname , x.VisitTime, x.VisitId, d.DName, d.DSurname, d.DoctorId};

                var dtoList = dto.ToList();

                var len = dtoList.Count;
                
                for (var i = 1 ; i < len; i++)
                {
                    docPatList.Add(new DocsPatientsDTO
                    {
                        DoctorId = dtoList[i].DoctorId,
                        DocName = dtoList[i].DName,
                        DocSurname = dtoList[i].DSurname,
                        PatName = dtoList[i].Name,
                        PatSurname = dtoList[i].Surname,
                        VisitTime = dtoList[i].VisitTime,
                        VisitId = dtoList[i].VisitId
                    });                
                }
            }
            catch (Exception e)
            {
                docPatList.Add( new DocsPatientsDTO
                {
                        DoctorId = 0,
                        DocName = "EMPTY",
                        DocSurname = "EMPTY",
                        PatName = "EMPTY",
                        PatSurname = "EMPTY",
                        VisitTime = new DateTime(00, 00, 00),
                        VisitId = 0
                });
            }
            return docPatList;
        }
    }
}
