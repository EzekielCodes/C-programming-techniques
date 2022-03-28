using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using opleiding.api.Entitties;
using opleiding.models.Docent;
using opleiding.models.Opos;
using Opleiding.api.DataLayer;
using Opleiding.api.Entitties;
using System.Diagnostics;
using System.Security.Claims;

namespace opleiding.api.Repositories;
public class OpoRepository : IOpoRepository
{
    private readonly OpleidingContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ClaimsPrincipal _persoon;

    public OpoRepository(OpleidingContext context, IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
        _persoon = _httpContextAccessor.HttpContext.User;
    }
    public async Task<bool> DeleteOpo(Guid id)
    {
        if (_persoon.Claims.Where(x => x.Type.Contains("rol")).Count() == 1 &&
           _persoon.IsInRole("student") || _persoon.Claims.Where(x => x.Type.Contains("rol")).Count() == 1 &&
           _persoon.IsInRole("docent"))
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
            catch (Exception ex)
            {
                Debug.WriteLine("Error");
            }
            return true;
        }

        else
        {
            throw new Exception("Geen toegang");
        }



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

        if(_persoon.Claims.Where(x => x.Type.Contains("role")).Count() == 1 &&
            _persoon.IsInRole("student")&&
            _persoon.Identity.Name != id.ToString())
        {
            throw new Exception("Student heeft geen toegang");
        }
        else
        {
            return oposModel;
        }
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

        if (_persoon.Claims.Where(x => x.Type.Contains("rol")).Count() == 1 &&
            _persoon.IsInRole("student") || _persoon.Claims.Where(x => x.Type.Contains("rol")).Count() == 1 &&
            _persoon.IsInRole("docent"))
        {
            return oposModel;
            
        }
        else
        {
            throw new Exception("Geen toegang");
        }
    }

    public async Task<GetOpoModel> PostOpo(PostOpoModel postOpoModel)
    {
        if (_persoon.Claims.Where(x => x.Type.Contains("rol")).Count() == 1 &&
            _persoon.IsInRole("student") || _persoon.Claims.Where(x => x.Type.Contains("rol")).Count() == 1 &&
            _persoon.IsInRole("docent"))
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
        else
        {
            throw new Exception("Geen toegang");
        }


    }

    public async Task<bool> PutOpo(Guid id, PutOpoModel putOpo)
    {

        if (_persoon.Claims.Where(x => x.Type.Contains("rol")).Count() == 1 &&
            _persoon.IsInRole("student") || _persoon.Claims.Where(x => x.Type.Contains("rol")).Count() == 1 &&
            _persoon.IsInRole("docent"))
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
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        else
        {
            throw new Exception("Geen toegang");
        }

    }

   
}
