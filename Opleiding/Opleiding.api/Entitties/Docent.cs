using opleiding.api.Entitties;
using System.ComponentModel.DataAnnotations;

namespace Opleiding.api.Entitties
{

    public class Docent : Personeelslid
    {
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(45, MinimumLength = 3)]
        [Required]
        public string Vakdomein { get; set; }
        public virtual ICollection<OpoDocent> OpoDocenten { get; set; }
    }
}
