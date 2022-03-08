using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3.Global;

[BsonDiscriminator("Persoon")]
[BsonKnownTypes(typeof(Student),typeof(Personeelslid))]
public abstract class Persoon
{
    public abstract string Familienaam { get; set; }
    public abstract string Voornaam { get; set; }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public abstract String Id { get; set; }
    
    public Persoon(string id , string familienaam, string voornaam)
    {
        Id = id;
        Familienaam = familienaam;
        Voornaam = voornaam;
    }
    public Persoon(string familienaam, string voornaam)
    {
        Familienaam = familienaam;
        Voornaam = voornaam;
    }

    public Persoon()
    {

    }


    public override String ToString() { return "Naam: " + Familienaam + " " + Voornaam + Id; }
}
