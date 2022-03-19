using opleiding.api.Entitties;
using System.ComponentModel.DataAnnotations;

namespace Opleiding.api.Entitties
{
    public class Opo
    {
        public Guid OpoId { get; set; }
        public virtual Docent OpoVerantwoordelijke { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(6, MinimumLength = 3)]
        [Required]
        public string Code { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(45, MinimumLength = 3)]
        [Required]
        public string Naam { get; set; }
        [Range(3, 18, ErrorMessage = "Waarde moet tussen {3} en {18} liggen")]
        public int Stp { get; set; }
        [Range(1, 3, ErrorMessage = "Waarde moet tussen {1} en {3} liggen")]
        public int Fase { get; set; }
        [Range(1, 2, ErrorMessage = "Waarde moet tussen {1} en {2} liggen")]
        public int Semester { get; set; }
        public Guid OpoVerantwoordelijkeID { get; set; }
        public virtual ICollection<OpoOpleiding> OpoOpleiding { get; set; }
        public virtual ICollection<OpoStudent> OpoStudenten { get; set; }
        public virtual ICollection<OpoDocent> OpoDocenten { get; set; }
    }
}
