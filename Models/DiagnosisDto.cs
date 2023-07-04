using SymptomScout.Shared.Domain;
using System.Collections.Generic;
using System.Linq;

namespace SymptomScout.Shared.Models
{
    public class DiagnosisDto
    {
        public int DiagnosisId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<SymptomDto>? Symptoms { get; set; }

        public DiagnosisDto() { }

        public DiagnosisDto(Diagnosis diagnosis)
        {
            DiagnosisId = diagnosis.DiagnosisId;
            Name = diagnosis.Name;
            Description = diagnosis.Description;
            Symptoms = diagnosis.Symptoms.Select(s => (SymptomDto) s).ToList();
        }

        public static implicit operator DiagnosisDto(Diagnosis diagnosis)
        {
            return new DiagnosisDto
            {
                DiagnosisId = diagnosis.DiagnosisId,
                Name = diagnosis.Name,
                Description = diagnosis.Description
            };
        }
    }
}
