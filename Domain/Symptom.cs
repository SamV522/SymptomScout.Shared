using SymptomScout.Shared.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace SymptomScout.Shared.Domain
{
    [Index(nameof(Name), IsUnique = true, Name = "UC_Symptom_Name")]
    public class Symptom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SymptomId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Diagnosis> Diagnoses { get; set; }

        public Symptom() { }

        public Symptom(SymptomDto symptom)
        {
            Name = symptom.Name;
            Description = symptom.Description;
            Diagnoses = symptom.Diagnoses?.Select(d => new Diagnosis()
            {
                DiagnosisId = d.DiagnosisId,
                Name = d.Name,
                Description = d.Description
            }).ToList() ?? new List<Diagnosis>();
        }
    }
}
