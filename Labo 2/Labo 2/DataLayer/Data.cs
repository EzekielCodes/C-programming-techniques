using Labo_2.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_2.DataLayer;

public class Data
{
    public List<Student> StudentLijst = new();

    public Data()
    {

        /*using (var db = new Model())
        {
            //db.Add(new Docent { Familienaam = "Donne", Voornaam = "Johan"});
            //db.Add(new Opo {Naam = "C# OO Programming",Code = "OGI02X",Stp = 6 ,fase = Fase.fase2,Semester = Semester.sem1 });
            db.SaveChanges();
        }*/

       /* using (var db = new Model())
        {
            db.Add(new Student { Familienaam = "debruyne", Voornaam = "Siemen" });
            db.SaveChanges();
        }*/
    }
}
