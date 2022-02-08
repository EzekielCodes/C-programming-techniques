using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1.Logica;

public class Opo
{
    public string Code { get; set; }
    private Fase Fase { get; set; }
    private Semester Semester { get; set; }
    public int Stp { get; set; }

    public string Naam { get; set; }

    public Opo(string code , string naam, int stp, Fase fase, Semester semester)
    {
        Code = code;
        Naam = naam;
        Fase = fase;
        Stp = stp;
        Semester = semester;
    }

    public override string ToString()
    {
        return Code + " " + Naam;
    }

    public int CompareTo(object obj)
    {

        if (obj == null) return 1;
        Opo otherOpo = obj as Opo;

        if (otherOpo != null)
            return this.Naam.CompareTo(otherOpo.Naam);
        else
            throw new ArgumentException("");
    }
}
