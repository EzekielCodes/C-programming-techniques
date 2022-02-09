using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1.Logica;

public class Student:Persoon
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

    public Student(String naam, String voornaam)
    {
        _naam = naam;
        _voornaam = voornaam;
    }
    

    public override string ToString()
    {
        return _naam + " " +  _voornaam;
    }

    public  int CompareTo(object obj)
    {
        
        if(obj == null) return 1;
        var otherStudent = obj as Student;

        if (otherStudent != null)
            return _naam.CompareTo(otherStudent._naam);
        else 
            throw new ArgumentException("");
    }
}
