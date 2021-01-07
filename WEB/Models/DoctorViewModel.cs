using BLL.Entities;
using BLL.DTO1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class DoctorViewModel
    {
        public IEnumerable<Doctor> Doctor { get; set; }
        public List<DoctorDTO> DoctorsDTO { get; set; }
        public IEnumerable<Visit> Visits { get; set; }
        public string DateBuffer { get; set; }

        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
    }
}