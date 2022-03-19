using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using opleiding.models.Opos;
using Opleiding.api.DataLayer;
using Opleiding.api.Entitties;

namespace opleiding.api.Repositories;
public class OpoRepository : IOpoRepository
{
    private readonly OpleidingContext _context;

    public OpoRepository(OpleidingContext context)
    {
        _context = context;
    }
    public async Task DeleteOpo(Guid id)
    {
        Opo opo = await _context.Opos.FirstOrDefaultAsync(x => x.OpoId == id);
        if(opo == null)
        {
            throw new NotImplementedException("Opo niet gevonden");
        }
        _context.Opos.Remove(opo);
        await _context.SaveChangesAsync();
        
    }

    public async Task<GetOpoModel> GetOpo(Guid id)
    {
        List<GetOpoModel> opos = await _context.Opos
            .Where(x => x.OpoId == id)
           .Select(x => new GetOpoModel
           {
               OpoId = x.OpoId,
               Stp = x.Stp,
               Code = x.Code,
               Fase = x.Fase,
               Semester = x.Semester,
               OpoVerantwoordelijke = x.OpoVerantwoordelijke.Voornaam + " " + x.OpoVerantwoordelijke.Familienaam,
               Naam = x.Naam,
               Docenten = x.OpoDocenten.Select(x => new models.Docent.BaseDocentModel
               {
                   Voornaam = x.Docent.Voornaam,
                   Familienaam = x.Docent.Familienaam
               }).ToList(),
               AantalStudenten = x.OpoStudenten.Count()
           })
           .AsNoTracking()
           .ToListAsync();

        GetOpoModel oposModel = new GetOpoModel
        {
            Opo = opos
        };

        return oposModel;
    }

    public async Task<List<GetOpoModel>> GetOpos()
    {
        List<GetOpoModel> opos = await _context.Opos
            .Select(x => new GetOpoModel
            {
                OpoId = x.OpoId,
                Stp = x.Stp,
                Code = x.Code,
                Fase = x.Fase,
                Semester = x.Semester,
                OpoVerantwoordelijke = x.OpoVerantwoordelijke.Voornaam + " " + x.OpoVerantwoordelijke.Familienaam,
                Naam = x.Naam,
                Docenten = x.OpoDocenten.Select(x => new models.Docent.BaseDocentModel
                {
                    Voornaam = x.Docent.Voornaam,
                    Familienaam = x.Docent.Familienaam
                }).ToList(),
                AantalStudenten = x.OpoStudenten.Count()
            })
            .AsNoTracking()
            .ToListAsync();

        return opos;
    }

    public async Task<GetOpoModel> PostOpo(PostOpoModel postOpoModel)
    {
        EntityEntry<Opo> result = await _context.Opos.AddAsync(new Opo
        {
            OpoId =postOpoModel.OpoId,
            Stp = postOpoModel.Stp,
            Code = postOpoModel.Code,
            Naam = postOpoModel.Naam,
            Semester = postOpoModel.Semester,
            Fase = postOpoModel.Fase,
            OpoVerantwoordelijkeID = postOpoModel.OpoVerantwoordelijkeID
        });

        await _context.SaveChangesAsync();
        return await GetOpo(result.Entity.OpoId);
    }

    public async Task PutOpo(Guid id, PutOpoModel putOpo)
    {

        Opo opo = await _context.Opos.FirstOrDefaultAsync(x => x.OpoId == id);
        if (opo == null)
        {
            throw new Exception("Opo niet gevonden");
        }
        opo.Code = putOpo.Code;
        opo.Naam = putOpo.Naam;
        opo.Stp = putOpo.Stp;
        opo.Semester = putOpo.Semester;
        opo.Fase = putOpo.Fase;
        opo.OpoId = putOpo.OpoId;

        await _context.SaveChangesAsync();
    }

   
}
