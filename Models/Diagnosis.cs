using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SymptomScout.Shared.Models
{
    public class Diagnosis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiagnosisId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [InverseProperty("Diagnosis")]
        public ICollection<Symptom> Symptoms { get; set; }
    }
}
