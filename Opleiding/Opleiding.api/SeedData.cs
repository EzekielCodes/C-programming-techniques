using Microsoft.EntityFrameworkCore;
using opleiding.api.Entitties;
using Opleiding.api.DataLayer;
using Opleiding.api.Entitties;
using System.Diagnostics;

namespace opleiding.api
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new OpleidingContext(serviceProvider.GetRequiredService<DbContextOptions<OpleidingContext>>()))
            {
                /* if (context.Opos.Any())
                 {
                     return;   // DB has been seeded
                 }

                 // docenten

                 Docent testDocent = new Docent()
                 {
                     Voornaam = "Sven",
                     Familienaam = "Knockaert",
                     Vakdomein = "Security"
                 };
                 Docent testDocent2 = new Docent()
                 {
                     Voornaam = "Johan",
                     Familienaam = "Donné",
                     Vakdomein = "Programmering"
                 };
                 Docent testDocent3 = new Docent()
                 {
                     Voornaam = "Peter",
                     Familienaam = "Demeester",
                     Vakdomein = "Database"
                 };
                 Docent testDocent4 = new Docent()
                 {
                     Voornaam = "Yves",
                     Familienaam = "Blancquaert",
                     Vakdomein = "Technique"
                 };

                Docent testDocent5 = new Docent()
                {
                    Voornaam = "Katja",
                    Familienaam = "Verbeeck",
                    Vakdomein = "Database"
                };

                Docent testDocent6 = new Docent()
                {
                    Voornaam = "Kristien",
                    Familienaam = "Van Assche",
                    Vakdomein = "Database"
                };

                // studenten

                Student akindele = new Student()
                 {
                     Voornaam = "Akindele",
                     Familienaam = "Ezekiel",
                     StudentenNummer = "r0842300"
                 };
                 Student cedar = new Student()
                 {
                     Voornaam = "Cedar",
                     Familienaam = "Nina",
                     StudentenNummer = "r0842301"
                 };
                 Student dave = new Student()
                 {
                     Voornaam = "Dave",
                     Familienaam = "sevn",
                     StudentenNummer = "r0842302"
                 };

                Student jacob = new Student()
                {
                    Voornaam = "jacob",
                    Familienaam = "sevn",
                    StudentenNummer = "r0842304"
                };

                Student derrick = new Student()
                {
                    Voornaam = "derrick",
                    Familienaam = "cartoon",
                    StudentenNummer = "r0842309"
                };
                // spare studenten

                // to be added

                // opos

                Opo techniques = new Opo
                 {
                     Naam = "C# Techniques",
                     OpoVerantwoordelijkeID = testDocent.Id,
                     Code = "OGI02Y",
                     Fase = 2,
                     Stp = 6,
                     Semester = 2,
                     OpoVerantwoordelijke = testDocent
                 };
                 Opo dataScience = new Opo
                 {
                     Naam = "Data science",
                     OpoVerantwoordelijkeID = testDocent2.Id,
                     Code = "OGI03A",
                     Fase = 2,
                     Stp = 6,
                     Semester = 2,
                     OpoVerantwoordelijke = testDocent2
                 };
                 Opo dataSecurity = new Opo
                 {
                     Naam = "Data Security",
                     OpoVerantwoordelijkeID = testDocent3.Id,
                     Code = "OGI02V",
                     Fase = 2,
                     Stp = 6,
                     Semester = 2,
                     OpoVerantwoordelijke = testDocent3
                 };

                 // add to db 

                 context.Studenten.AddRange(akindele, cedar, dave,jacob,derrick);

                 context.Docenten.AddRange(testDocent, testDocent2, testDocent3, testDocent4,testDocent5,testDocent6);

                 context.Opos.AddRange(techniques, dataScience, dataSecurity);

                 OpoDocent opoDocentDataScience = new OpoDocent()
                 {
                     DocentId = testDocent.Id,
                     //Docent = testDocent,
                     OpoId = dataSecurity.OpoId,
                     //Opo = dataScience
                 };

                 OpoDocent opoDocenttechnique = new OpoDocent()
                 {
                     DocentId = testDocent.Id,
                     OpoId = techniques.OpoId,
                 };

                 OpoDocent opoDocentDataSecurity = new OpoDocent()
                 {
                     DocentId = testDocent2.Id,
                     OpoId = dataScience.OpoId,
                 };

                OpoDocent opoDocentDataSecurity2 = new OpoDocent()
                {
                    DocentId = testDocent.Id,
                    OpoId = dataScience.OpoId,
                };

                OpoStudent opoStudent = new OpoStudent()
                 {
                     StudentId = akindele.Id,
                     //Student = vito,
                     OpoId = dataScience.OpoId,
                     //Opo = dataSecurity
                 };
                 OpoStudent opoStudent2 = new OpoStudent()
                 {
                     StudentId = cedar.Id,
                     OpoId = dataSecurity.OpoId,
                 };
                 OpoStudent opoStudent3 = new OpoStudent()
                 {
                     StudentId = dave.Id,
                     OpoId = techniques.OpoId,
                 };

                 OpoStudent opoStudent4 = new OpoStudent()
                 {
                     StudentId = cedar.Id,
                     OpoId = techniques.OpoId,
                 };
                 context.OpoStudenten.AddRange(opoStudent, opoStudent2, opoStudent3,opoStudent4);
                 context.OpoDocenten.AddRange(opoDocentDataScience,opoDocentDataSecurity, opoDocenttechnique,opoDocentDataSecurity2);
                


                context.SaveChanges();*/
            }
        }
    }}


