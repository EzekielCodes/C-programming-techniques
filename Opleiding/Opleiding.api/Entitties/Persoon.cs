using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Opleiding.api.Entitties
{

    public abstract class Persoon : IdentityUser<Guid>
    {
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(45, MinimumLength = 3)]
        [Required]
        public string Familienaam { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(45, MinimumLength = 3)]
        [Required]
        public string Voornaam { get; set; }
        public virtual ICollection<PersoonRol> PersoonRollen { get; set; }

    }
}
