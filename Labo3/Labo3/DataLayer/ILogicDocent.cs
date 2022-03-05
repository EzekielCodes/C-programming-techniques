using Labo3.Global;

namespace Labo3.DataLayer;

public interface ILogicDocent
{
    void AddDocent(Docent s);
    void Addopo(Docent docent, Opo opo);
    void DeleteDocent(Docent d);
    List<Docent> GetDocent();
    void RemoveOpo(Docent docent, Opo opo);
}