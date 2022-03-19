using opleiding.models.Opos;

namespace opleiding.api.Repositories;

public interface IOpoRepository
{
    Task<List<GetOpoModel>> GetOpos();
    Task<GetOpoModel> GetOpo(Guid id);
    Task<GetOpoModel> PostOpo(PostOpoModel postOpoModel);
    Task PutOpo(Guid id, PutOpoModel putOpo);
    Task DeleteOpo(Guid id);
}
