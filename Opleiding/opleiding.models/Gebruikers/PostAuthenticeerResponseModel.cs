using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace opleiding.models.Gebruikers;

public class PostAuthenticeerResponseModel
{
    public Guid Id { get; set; }
    public string Voornaam { get; set; }
    public string Familienaam { get; set; }
    public string Gebruikersnaam { get; set; }
    public string JwtToken { get; set; }
    public ICollection<string> Rollen { get; set; }

    [JsonIgnore] // refresh token is returned in http only cookie
    public string RefreshToken { get; set; }
}
