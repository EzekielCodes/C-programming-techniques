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
        public int Stp { get; set; }
        public int fase { get; set; }
        public int semester { get; set; }
        public virtual ICollection<OpoOpleiding> OpoOpleiding { get; set; }
        public virtual ICollection<OpoStudent> OpoStudenten { get; set; }
        public virtual ICollection<OpoDocent> OpoDocenten { get; set; }
    }
}
