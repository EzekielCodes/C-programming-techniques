using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Opleiding.api.Entitties
{

    public class Rol : IdentityRole<Guid>
    {
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(45, MinimumLength = 3)]
        [Required]
        public string Naam;
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(45, MinimumLength = 3)]
        [Required]
        public string Omschrijving;
        public virtual ICollection<PersoonRol> PersoonRollen { get; set; }
    }
}
