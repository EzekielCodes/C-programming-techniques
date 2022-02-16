using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1.Logica;

public class Opo
{
    public string Code { get; set; }
    private Fase fase { get; set; }
    private Semester Semester { get; set; }
    private int _stp;
    public int Stp
    {
        get { return _stp; }
        set { _stp = value; }
    }

    public string Naam { get; set; }

    public Opo(string code , string naam, int stp, Fase fase, Semester semester)
    {
        Code = code;
        Naam = naam;
        this.fase = fase;
        Stp = stp;
        Semester = semester;
    }

    public override string ToString()
    {
        return Code + ": " + Naam + "(" + Stp + " stp, " + fase + "," + Semester + ")";
    }

    public int CompareTo(object obj)
    {

        if (obj == null) return 1;

        if (obj as Opo != null)
            return Code.CompareTo((obj as Opo).Code);
        else
            throw new ArgumentException("");
    }
}
