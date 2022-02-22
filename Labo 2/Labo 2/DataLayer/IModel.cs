using Labo_2.Logica;
using Microsoft.EntityFrameworkCore;

namespace Labo_2.DataLayer;

public interface IModel
{
    DbSet<Docent> Docent { get; set; }
    DbSet<Opo> Opo { get; set; }
    DbSet<Personeelslid> Personeel { get; set; }
    DbSet<Persoon> Persoon { get; set; }
    DbSet<Student> Student { get; set; }
}