﻿using System;
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
}
