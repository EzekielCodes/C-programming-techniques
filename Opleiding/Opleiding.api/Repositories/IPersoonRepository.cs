using opleiding.models.Gebruikers;
namespace opleiding.api.Repositories
{
    public interface IPersoonRepository
    {
        Task<PostAuthenticeerResponseModel> Authenticeer(PostAuthenticeerRequestModel postAuthenticeerRequestModel, String ipAddress);
        Task<PostAuthenticeerResponseModel> VernieuwToken(string token, string ipAddress);
        Task DeactiveerToken(string token, string ipAddress);
    }
}


