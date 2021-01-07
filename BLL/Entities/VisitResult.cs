using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.Entities
{
    public class VisitResult
    {
        [Key]
        public int DiagnosisId { get; set; }
        public int VisitId { get; set; }
        public string Diagnosis { get; set; }
    }
}
