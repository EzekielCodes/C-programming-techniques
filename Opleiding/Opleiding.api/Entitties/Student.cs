using opleiding.api.Entitties;
using System.ComponentModel.DataAnnotations;

namespace Opleiding.api.Entitties
{

    public class Student : Persoon
    {
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(45, MinimumLength = 3)]
        [Required]
        public string StudentenNummer { get; set; }
        public virtual ICollection<OpoStudent> OpoStudenten { get; set; }
    }
}
