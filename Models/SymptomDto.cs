using SymptomScout.Shared.Domain;
using System.Collections.Generic;

namespace SymptomScout.Shared.Models
{
    public class SymptomDto
    {
        public int SymptomId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Diagnosis>? Diagnoses { get; set; }

        public SymptomDto() { }

        public SymptomDto(int id, string name, string description, IList<Diagnosis> diagnoses) 
        {
            SymptomId = id;
            Name = name;
            Description = description;
            Diagnoses = diagnoses;
        }
    }
}
