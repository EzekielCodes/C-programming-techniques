using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3.Global;

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

    private string _id;

    public override string Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public abstract String Personnelsnummer { get; set; }
}
