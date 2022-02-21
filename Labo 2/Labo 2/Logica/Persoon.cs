using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_2.Logica;

public abstract class Persoon
{
    public abstract string Familienaam { get; set; }
    public abstract string Voornaam { get; set; }
    public abstract int Id { get; set; }

    public override String ToString() { return "Naam: " + Familienaam + " " + Voornaam + Id ; }
}
