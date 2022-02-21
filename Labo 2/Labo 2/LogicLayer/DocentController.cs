using Labo_2.Logica;
using SharpRepository.EfCoreRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_2.LogicLayer;

public class DocentController : BaseController
{
    protected EfCoreRepository<Docent> repoDocent;
    public DocentController()
    {
        repoDocent = new EfCoreRepository<Docent>(m);
    }

    public List<Docent> GetDocent()
    {
        return (List<Docent>)repoDocent.GetAll();
    }

    public void AddDocent(Docent s)
    {
        repoDocent.Add(s);
    }

    public void Addopo(Docent docent, Opo opo)
    {
        repoDocent.Get(docent.Id).VoegOPOToe(opo);
        repoDocent.Update(docent);
    }

    public void RemoveOpo(Docent docent, Opo opo)
    {
        repoDocent.Get(docent.Id).VerwijderOPO(opo);
        repoDocent.Update(docent);
    }

}
