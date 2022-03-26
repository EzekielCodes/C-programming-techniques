using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opleiding.models.Gebruikers;

public  class PostAuthenticeerRequestModel
{
    [Required(ErrorMessage = "Gebruikersnaam is verplicht")]
    public String Gebruikersnaam { get; set; }

    [Required(ErrorMessage = "wachtwoord is verplicht")]
    public string Wachtwoord { get; set; }
}
