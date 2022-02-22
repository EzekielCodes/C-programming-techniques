using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_2.Logica;

public class Student : Persoon, IComparable<Student>
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
    private String _studentnummer;
    public String Studentnummer
    {
        get { return _studentnummer; }
        set { _studentnummer = value; }
    }
    public virtual  List<Opo> OpoList { get; set; }
    

    public Student(int id ,String naam, String voornaam, String studentnr)
    {
        _naam = naam;
        _voornaam = voornaam;
        _id = id;
        _studentnummer = studentnr;
        OpoList = new List<Opo>();
    }
    public Student(String naam, String voornaam, String studentnr)
    {
        _naam = naam;
        _voornaam = voornaam;
        _studentnummer = studentnr;
        OpoList = new List<Opo>();
    }
    public Student()
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
        int index = OpoList.FindIndex(o => o.Id == opo.Id);

        Debug.WriteLine(index);

        if (OpoList.Any(code => code.Id == opo.Id))
        {
            OpoList.RemoveAt(index);
        }
        OpoList.OrderBy(o => o.Code);

    }

    public int CompareTo(Student? other)
    {

        if (other != null)
            return _naam.CompareTo(other._naam);
        else
            return _voornaam.CompareTo(other._voornaam);
    }
}