using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SymptomScout.Shared.Models
{
    public class Symptom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SymptomId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Diagnosis> Diagnoses { get; set; }
    }
}
