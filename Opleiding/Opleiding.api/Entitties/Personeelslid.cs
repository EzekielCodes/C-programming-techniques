using System.ComponentModel.DataAnnotations;

namespace Opleiding.api.Entitties
{

    public abstract class Personeelslid : Persoon
    {
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(45, MinimumLength = 3)]
        [Required]
        public String Personnelsnummer { get; set; }
    }
}
