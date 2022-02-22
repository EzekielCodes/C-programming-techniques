using Labo_2.Logica;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_2.DataLayer;

public class Model : DbContext, IModel
{
    public DbSet<Persoon> Persoon { get; set; }
    public DbSet<Personeelslid> Personeel { get; set; }
    public DbSet<Opo> Opo { get; set; }
    public DbSet<Student> Student { get; set; }
    public DbSet<Docent> Docent { get; set; }
    public Model()
    {
        //_connectionString = "SERVER=localhost;DATABASE=laboapplicatie02;UID=Akindele;PASSWORD=Azerty123";

    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options
        .UseMySql("SERVER=localhost;DATABASE=laboapplicatie02;UID=Akindele;PASSWORD=Azerty123", new MySqlServerVersion(new Version(8, 0, 27)))
        .UseLazyLoadingProxies();
}
