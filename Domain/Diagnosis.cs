using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace SymptomScout.Shared.Domain
{
    [Index(nameof(Name), IsUnique = true, Name = "UC_Diagnosis__Name")]
    public class Diagnosis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiagnosisId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Symptom> Symptoms { get; set; }
    }
}
