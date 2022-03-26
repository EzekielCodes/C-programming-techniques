using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using opleiding.api.Entitties;
using opleiding.models.Docent;
using opleiding.models.Opos;
using Opleiding.api.DataLayer;
using Opleiding.api.Entitties;
using System.Diagnostics;

namespace opleiding.api.Repositories;
public class OpoRepository : IOpoRepository
{
    private readonly OpleidingContext _context;

    public OpoRepository(OpleidingContext context)
    {
        _context = context;
    }
    public async Task<bool> DeleteOpo(Guid id)
    {
        try
        {
            Opo opo = await _context.Opos.FirstOrDefaultAsync(x => x.OpoId == id);
            if (opo == null)
            {
                throw new NotImplementedException("Opo niet gevonden");
                return false;
            }
            // Remove Opo from OpoDocenten
            List<OpoDocent> DocentenVanOpo = opo.OpoDocenten.ToList();
            foreach (var opoDocent in DocentenVanOpo)
            {
                _context.OpoDocenten.Remove(opoDocent);
            }
            // Remove Opo from OpoStudenten
            // _context.OpoStudenten.Where(o => o.OpoId == id).ToList();
            List<OpoStudent> StudentenVanOpo = opo.OpoStudenten.ToList();
            foreach (var opoStudent in StudentenVanOpo)
            {
                _context.OpoStudenten.Remove(opoStudent);
            }
            _context.Opos.Remove(opo);
            await _context.SaveChangesAsync();
        }
        catch(Exception ex)
        {
            Debug.WriteLine("Error");
        }
        return true;
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
               Docenten = x.OpoDocenten.Select(x => x.Docent.Voornaam + " " + x.Docent.Familienaam).ToList(),
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

    public async Task<GetOposModel> GetOpos()
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
                Docenten = x.OpoDocenten.Select(x => x.Docent.Voornaam + " " + x.Docent.Familienaam).ToList(),
                AantalStudenten = x.OpoStudenten.Count()
            })
            .AsNoTracking()
            .ToListAsync();


        GetOposModel oposModel = new GetOposModel
        {
            Opos = opos
        };

        return oposModel;
    }

    public async Task<GetOpoModel> PostOpo(PostOpoModel postOpoModel)
    {
        EntityEntry<Opo> result = await _context.Opos.AddAsync(new Opo
        {
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

    public async Task<bool> PutOpo(Guid id, PutOpoModel putOpo)
    {
        try
        {
            Opo opo = await _context.Opos.FirstOrDefaultAsync(x => x.OpoId == id);
            if (opo == null)
            {
                throw new Exception("Opo niet gevonden");
                return false;
            }
           
            opo.Code = putOpo.Code;
            opo.Naam = putOpo.Naam;
            opo.Stp = putOpo.Stp;
            opo.Semester = putOpo.Semester;
            opo.Fase = putOpo.Fase;

            putOpo.StudentenID.ForEach(studentId =>
            {
                var opoStudent = new OpoStudent();
                opoStudent.StudentId = studentId;
                opoStudent.OpoId = id;
                if (!opo.OpoStudenten.Contains(opoStudent))
                {
                    opo.OpoStudenten.Add(opoStudent);
                }
            });

            await _context.SaveChangesAsync();
        }
        catch(Exception ex)
        {
            return false;
        }
        return true;
        
    }

   
}
