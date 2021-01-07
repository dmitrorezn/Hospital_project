using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO1
{
    public class DocsPatientsDTO
    {
        public int DoctorId { get; set; }
        public string DocName { get; set; }
        public string DocSurname { get; set; }
        public string PatName { get; set; }
        public string PatSurname { get; set; }
        public DateTime VisitTime { get; set; }
        public int VisitId { get; set; }
    }
}
