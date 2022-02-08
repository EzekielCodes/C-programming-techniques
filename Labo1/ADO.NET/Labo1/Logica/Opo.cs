using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1.Logica;

public class Opo
{
    private string _code;
    public string Code
    {
        get { return _code; }
        set { _code = value; }
    }
    private Fase _fase { get; set; }
    private Semester _semester { get; set; }

    private int _stp;
    public int Stp
    {
        get { return _stp; }
        set { _stp = value; }
    }
    private string _naam;
    public string Naam
    {
        get { return _naam; }
        set { _naam = value; }
    }

    public Opo(string code , string naam, int stp, Fase fase, Semester semester)
    {

    }
}
