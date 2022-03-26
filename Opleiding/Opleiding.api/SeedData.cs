using Microsoft.AspNetCore.Identity;
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
            using var context = new OpleidingContext(serviceProvider.GetRequiredService<DbContextOptions<OpleidingContext>>());
            using UserManager<Persoon> _userManager = serviceProvider.GetRequiredService<UserManager<Persoon>>();
            using RoleManager<Rol> _roleManager = serviceProvider.GetRequiredService<RoleManager<Rol>>();

            // roles aanmaken

            if (!context.Roles.Any())
            {
                foreach (string line in File.ReadLines(@"C:\Users\Guest\Desktop\rollen.txt"))
                {
                    String[] rol = line.Split(';');
                    Debug.WriteLine(String.Join("", rol));
                    _ = _roleManager.CreateAsync(new Rol { Name = rol[0], Naam = rol[1] }).Result;
                }
            }

            if (!context.Users.Any())
            {
                foreach (string line in File.ReadLines(@"C:\Users\Guest\Desktop\Opleidingdocenten.txt"))
                {
                    if (line.Contains(';'))
                    {
                        string[] docentDetails = line.Split(';');
                        Docent docent = new()
                        {
                            Voornaam = docentDetails[0],
                            Familienaam = docentDetails[1],
                            Email = docentDetails[2],
                            UserName = docentDetails[2],
                            Personnelsnummer = docentDetails[4],
                            Vakdomein = docentDetails[5],

                        };

                        _ = _userManager.CreateAsync(docent, "_Azerty123").Result;
                        _ = _userManager.AddToRoleAsync(docent, docentDetails[6]).Result;
                    }
                }

                foreach (string line in File.ReadLines(@"C:\Users\Guest\Desktop\OpleidingStudenten.txt"))
                {
                    if (line.Contains(';'))
                    {
                        string[] studentDetails = line.Split(';');
                        Student student = new()
                        {
                            Voornaam = studentDetails[0],
                            Familienaam = studentDetails[1],
                            UserName = studentDetails[2],
                            Email = studentDetails[2],
                            StudentenNummer = studentDetails[3],

                        };

                        _= _userManager.CreateAsync(student, "_Azerty123").Result;
                        _= _userManager.AddToRoleAsync(student, studentDetails[4]).Result;

                    }

                }
            }

            if (!context.Opos.Any())
            {
                foreach (string line in File.ReadLines(@"C:\Users\Guest\Desktop\OpleidingOpos.txt"))
                {
                    string[] opoDetails = line.Split(';');
                    Docent docent = context.Docenten.First(x => x.Email.ToLower().Equals(opoDetails[5].ToLower()));

                    Opo opo = new()
                    {
                        Code = opoDetails[0],
                        Naam = opoDetails[1],
                        Stp = int.Parse(opoDetails[2]),
                        Fase = int.Parse(opoDetails[3]),
                        Semester = int.Parse(opoDetails[4]),
                        OpoVerantwoordelijke = docent,
                    };

                    context.Opos.Add(opo);

                    context.SaveChanges();
                }
            }

            if (!context.OpoDocenten.Any())
            {
                foreach (string line in File.ReadLines(@"C:\Users\Guest\Desktop\OpleidingOpoDocenten.txt"))
                {
                    string[] opoDetails = line.Split(';');
                    Opo opo = context.Opos.First(x => x.Code.ToLower().Equals(opoDetails[0].ToLower()));
                    Docent docent = context.Docenten.First(x => x.Email.ToLower().Equals(opoDetails[1].ToLower()));

                    OpoDocent opoDocent = new()
                    {
                        Opo = opo,
                        Docent = docent,
                    };

                    context.OpoDocenten.Add(opoDocent);
                    context.SaveChanges();
                }
            }

            if (!context.OpoStudenten.Any())
            {

                foreach (string line in File.ReadLines(@"C:\Users\Guest\Desktop\OpleidingOpoStudenten.txt"))
                {
                    string[] opoDetails = line.Split(';');
                    Opo opo = context.Opos.First(x => x.Code.ToLower().Equals(opoDetails[0].ToLower()));
                    Student student = context.Studenten.First(x => x.Email.ToLower().Equals(opoDetails[1].ToLower()));

                    OpoStudent opoStudent = new()
                    {
                        Opo = opo,
                        Student = student,
                    };
                    context.OpoStudenten.Add(opoStudent);
                    context.SaveChanges();
                }
            } }}
}


