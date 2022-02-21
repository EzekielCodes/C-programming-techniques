using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_2.Logica;

public abstract class Personeelslid : Persoon
{
    private String _naam;
    public override string Familienaam
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
    private int _id;
   
    public override int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public  abstract String Personnelsnummer { get; set; }
}
