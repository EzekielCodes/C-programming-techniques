using opleiding.models.Opos;

namespace opleiding.api.Repositories;

public interface IOpoRepository
{
    Task<GetOposModel> GetOpos();
    Task<GetOpoModel> GetOpo(Guid id);
    Task<GetOpoModel> PostOpo(PostOpoModel postOpoModel);
    Task<bool> PutOpo(Guid id, PutOpoModel putOpo);
    Task<bool> DeleteOpo(Guid id);
}
