using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    }
}
