using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_2.Logica;

public class Docent : Personeelslid,IComparable<Docent>
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
    private String _personnelsnummer;
    public override String Personnelsnummer
    {
        get { return _personnelsnummer; }
        set { _personnelsnummer = value; }
    }
    public virtual List<Opo> OpoList { get; set; }

    public Docent(int id, String naam, String vnaam,String personnelnr)
    {
        _naam = naam;
        _voornaam = vnaam;
        _id = id;
        _personnelsnummer = personnelnr;
        OpoList = new List<Opo>();
    }

    public Docent(String naam, String vnaam, String personnelnr)
    {
        _naam = naam;
        _voornaam = vnaam;
        _personnelsnummer = personnelnr;
        OpoList = new List<Opo>();
    }
    public Docent()
    {
        OpoList = new List<Opo>();
    }

    public override string ToString()
    {
        return _naam + " " + _voornaam ;
    }

    public void VoegOPOToe(Opo opo)
    { 
        if (!OpoList.Contains(opo))
        {
                OpoList.Add(opo);
         }
        OpoList.Sort();

    }

    public void VerwijderOPO(Opo opo)
    {
       if (OpoList.Any(code => code.Code == opo.Code))
        {
            
            OpoList.Remove(opo);
        }
        OpoList.Sort();
    }

    public int CompareTo(Docent? other)
    {
       
        if (other != null)
            return _naam.CompareTo(other._naam);
        else
            return _voornaam.CompareTo(other._voornaam);
    }
}
