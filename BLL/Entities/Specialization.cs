using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.Entities
{
    public class Specialization
    {
        [Key]
        public int SpecializationId { get; set; }
        public string Name { get; set; }
    }
}
