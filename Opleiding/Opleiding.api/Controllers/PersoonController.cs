using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using opleiding.api.Repositories;
using opleiding.models.Gebruikers;

namespace opleiding.api.Controllers;


[Authorize(AuthenticationSchemes = "Bearer")]
[Route("api/[controller]")]
[ApiController]
[Produces("application/json")]
[Consumes("application/json")]
public class PersoonController : ControllerBase
{
    private readonly IPersoonRepository _persoonRepository;

    public PersoonController(IPersoonRepository persoonRepository)
    {
        _persoonRepository = persoonRepository; 
    }

    private void SetTokenCookie(string token)
    {
        CookieOptions cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Expires = DateTime.UtcNow.AddMinutes(2), //TOKEN
            IsEssential = true
        };

        Response.Cookies.Append("Opleiding.RefreshToken", token, cookieOptions);
    }

    private string IpAddress()
    {
        if (Request.Headers.ContainsKey("X-Forwarded-For"))
        {
            return Request.Headers["X-Forwarded-For"];
        }
        else
        {
            return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }
    }

    [AllowAnonymous]
    [HttpPost("authenticeer")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<ActionResult<PostAuthenticeerResponseModel>> Authenticeer(PostAuthenticeerRequestModel postAuthenticeerRequestModel)
    {
        try
        {
            PostAuthenticeerResponseModel postAuthenticeerResponseModel = await _persoonRepository.Authenticeer(postAuthenticeerRequestModel, IpAddress());

            SetTokenCookie(postAuthenticeerResponseModel.RefreshToken);

            return postAuthenticeerResponseModel;
        }
        catch (Exception e)
        {
            return Unauthorized(e.Message);
        }
    }

    [AllowAnonymous]
    [HttpPost("vernieuw-token")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<ActionResult<PostAuthenticeerResponseModel>> VernieuwToken()
    {
        try
        {
            string refreshToken = Request.Cookies["Opleiding.RefreshToken"];

            PostAuthenticeerResponseModel postAuthenticeerResponseModel = await _persoonRepository.VernieuwToken(refreshToken, IpAddress());

            SetTokenCookie(postAuthenticeerResponseModel.RefreshToken);

            return postAuthenticeerResponseModel;
        }
        catch (Exception e)
        {
            return Unauthorized(e.Message);
        }
    }

    [HttpPost("deactiveer-token")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [Authorize(Roles = "beheerder")]
    public async Task<IActionResult> DeactiveerToken(PostDeactiveerTokenRequestModel postRevokeTokenRequestModel)
    {
        try
        {
            // Accept token from request body or cookie
            string token = postRevokeTokenRequestModel.Token ?? Request.Cookies["Opleiding.RefreshToken"];

            if (string.IsNullOrEmpty(token))
            {
                throw new Exception("Refresh token is verplicht");
            }

            await _persoonRepository.DeactiveerToken(token, IpAddress());

            return Ok();
        }
        catch (Exception e)
        {
            return Unauthorized(e.Message);
        }
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Authorize(Roles = "gast")]
    public async Task<ActionResult<GetGastModel>> GetPersoon()
    {

        try
        {
            string refreshToken = Request.Cookies["Opleiding.RefreshToken"];

            GetGastModel getGastenProfiel = await _persoonRepository.GetGastProfiel(refreshToken);

            return getGastenProfiel;
        }
        catch(Exception e)
        {
            return Unauthorized(e.Message);
        } 
    }
}
