using Labo_2.Logica;
using SharpRepository.EfCoreRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_2.LogicLayer;

public class OpoController : BaseController, IOpoController
{
    protected EfCoreRepository<Opo> repoOpo;

    public OpoController()
    {
        repoOpo = new EfCoreRepository<Opo>((Microsoft.EntityFrameworkCore.DbContext)m);
    }

    public List<Opo> GetOpo()
    {
        return (List<Opo>)repoOpo.GetAll();
    }

    public void AddOpo(Opo s)
    {
        repoOpo.Add(s);
    }
}
