using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1.Logica;

public abstract class Persoon
{
    public abstract string Naam { get; set; }
    public abstract string Voornaam { get; set; }

    public override String ToString() { return "Naam: " + Naam + " " + Voornaam; }
}
