using Labo3.Global;

namespace Labo3.DataLayer;

public interface ILogicOpo
{
    void AddOpo(Opo s);
    void DeleteOpo(Opo s);
    List<Opo> GetOpo();
}