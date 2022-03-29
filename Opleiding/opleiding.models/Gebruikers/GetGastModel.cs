using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opleiding.models.Gebruikers;

public class GetGastModel
{
    [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
    [StringLength(45, MinimumLength = 3)]
    [Required]
    public string Familienaam { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
    [StringLength(45, MinimumLength = 3)]
    [Required]
    public string Voornaam { get; set; }
    public String Gebruikersnaam { get; set; }

    public string Email { get; set; }
    
}
