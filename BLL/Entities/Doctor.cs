using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.Entities
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public string DName { get; set; }
        public string DSurname { get; set; }
        public int SpecializationId { get; set; }
    }
}
