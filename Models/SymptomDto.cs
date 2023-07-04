using SymptomScout.Shared.Domain;
using System.Collections.Generic;
using System.Linq;

namespace SymptomScout.Shared.Models
{
    public class SymptomDto
    {
        public int SymptomId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<DiagnosisDto>? Diagnoses { get; set; }

        public SymptomDto() { }

        public SymptomDto(Symptom symptom) 
        {
            SymptomId = symptom.SymptomId;
            Name = symptom.Name;
            Description = symptom.Description;
        }

        public SymptomDto(Symptom symptom, ICollection<Diagnosis> diagnoses) : this(symptom)
        {
            Diagnoses = diagnoses.Select(d => (DiagnosisDto) d).ToList();
        }

        public static implicit operator SymptomDto(Symptom symptom)
        {
            return new SymptomDto
            {
                SymptomId = symptom.SymptomId,
                Name = symptom.Name,
                Description = symptom.Description
            };
        }
    }
}
