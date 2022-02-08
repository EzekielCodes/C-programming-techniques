using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1.Logica;

public class Docent:Personeelslid
{
    private String _naam;
    public override string Naam
    {
        get { return _naam; }
        set { _naam = value; }
    }
    private String _voornaam;
    public override string Voornaam
    {
        get { return _voornaam; }
        set { _voornaam = value; }
    }

    public Docent(String naam, String vnaam)
    {
        _naam = naam;
        _voornaam = vnaam;
    }

    public override string ToString()
    {
        return _naam + " " + _voornaam;
    }

    public int CompareTo(object obj)
    {

        if (obj == null) return 1;
        Docent otherDocent = obj as Docent;

        if (otherDocent != null)
            return this._naam.CompareTo(otherDocent._naam);
        else
            throw new ArgumentException("");
    }

}
