using Labo_2.Logica;

namespace Labo_2.LogicLayer;

public interface IDocentController
{
    void AddDocent(Docent s);
    void Addopo(Docent docent, Opo opo);
    List<Docent> GetDocent();
    void RemoveOpo(Docent docent, Opo opo);
}