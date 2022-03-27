using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using opleiding.api.Entitties;
using opleiding.models.Gebruikers;
using Opleiding.api.Entitties;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using opleiding.api.Helper;

namespace opleiding.api.Repositories
{
    public class PersoonRepository : IPersoonRepository
    {
        private readonly SignInManager<Persoon> _signInManager;
        private readonly UserManager<Persoon> _userManager;
        private readonly IAppSettings _appSettings;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ClaimsPrincipal _persoon;

        public PersoonRepository(SignInManager<Persoon> signInManager, UserManager<Persoon> userManager, IAppSettings appSettings, IHttpContextAccessor httpContextAccessor)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _appSettings = appSettings;
            _httpContextAccessor = httpContextAccessor;
            _persoon = _httpContextAccessor.HttpContext.User;
        }

        public async Task<PostAuthenticeerResponseModel> Authenticeer(PostAuthenticeerRequestModel postAuthenticeerRequestModel, string ipAddress)
        {
            Persoon persoon = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == postAuthenticeerRequestModel.Gebruikersnaam);

            if (persoon == null)
            {
                throw new Exception("Ongeldig e-mailadress");
            }

            SignInResult signInResult = await _signInManager.CheckPasswordSignInAsync(persoon, postAuthenticeerRequestModel.Wachtwoord, lockoutOnFailure: false);

            if (!signInResult.Succeeded)
            {
                throw new Exception("Ongeldig wachtwoord");
            }

            string jwtToken = await GenerateJwtToken(persoon);
            RefreshToken refreshToken = GenerateRefreshToken(ipAddress);

            persoon.RefreshTokens.Add(refreshToken);
            await _userManager.UpdateAsync(persoon);

            return new PostAuthenticeerResponseModel
            {
                Id = persoon.Id,
                Voornaam = persoon.Voornaam,
                Familienaam = persoon.Familienaam,
                Gebruikersnaam = persoon.UserName,
                JwtToken = jwtToken,
                RefreshToken = refreshToken.Token,
                Rollen = await _userManager.GetRolesAsync(persoon)
            };
        }

        public async Task DeactiveerToken(string token, string ipAddress)
        {
            Persoon persoon = await _userManager.Users
                   .FirstOrDefaultAsync(x => x.RefreshTokens.Any(t => t.Token == token));

            if (persoon == null)
            {
                throw new Exception("Geen gebruiker gevonden met dit token RefreshToken 401");
            }

            RefreshToken refreshToken = persoon.RefreshTokens.Single(x => x.Token == token);

            // Refresh token is no longer active
            if (!refreshToken.IsActive)
            {
                throw new Exception("Refresh token is vervallen RefreshToken 401");
            };

            // Revoke token and save
            refreshToken.Revoked = DateTime.UtcNow;
            refreshToken.RevokedByIp = ipAddress;

            await _userManager.UpdateAsync(persoon);
        }

        public async Task<PostAuthenticeerResponseModel> VernieuwToken(string token, string ipAddress)
        {
            Persoon persoon = await _userManager.Users.FirstOrDefaultAsync(x => x.RefreshTokens.Any(t => t.Token == token));

            if (persoon == null)
            {
                throw new Exception("Geen gebruiker gevonden met dit token RefreshToken 401");
            }

            RefreshToken refreshToken = persoon.RefreshTokens.Single(x => x.Token == token);

            // Refresh token is no longer active
            if (!refreshToken.IsActive)
            {
                throw new Exception("Refresh token is vervallen RefreshToken 401");
            };

            // Replace old refresh token with a new one
            RefreshToken newRefreshToken = GenerateRefreshToken(ipAddress);
            refreshToken.Revoked = DateTime.UtcNow;
            refreshToken.RevokedByIp = ipAddress;
            refreshToken.ReplacedByToken = newRefreshToken.Token;

            // Generate new jwt
            string jwtToken = await GenerateJwtToken(persoon);

            persoon.RefreshTokens.Add(newRefreshToken);

            await _userManager.UpdateAsync(persoon);

            return new PostAuthenticeerResponseModel
            {
                Id = persoon.Id,
                Voornaam = persoon.Voornaam,
                Familienaam = persoon.Familienaam,
                Gebruikersnaam = persoon.UserName,
                JwtToken = jwtToken,
                RefreshToken = newRefreshToken.Token,
                Rollen = await _userManager.GetRolesAsync(persoon)
            };
        }
        private RefreshToken GenerateRefreshToken(string ipAddress)
        {

            byte[] randomBytes = RandomNumberGenerator.GetBytes(64);

            // The refresh token expires time must be the same as the refresh token 
            // cookie expires time set in the SetTokenCookie method in UsersController
            return new RefreshToken
            {
                Token = Convert.ToBase64String(randomBytes),
                Expires = DateTime.UtcNow.AddMinutes(2), //TOKEN
                Created = DateTime.UtcNow,
                CreatedByIp = ipAddress
            };
        }

        private async Task<string> GenerateJwtToken(Persoon persoon)
        {
            var roleNames = await _userManager.GetRolesAsync(persoon).ConfigureAwait(false);

            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.Name, persoon.Id.ToString()),
                new Claim("Voornaam", persoon.Voornaam),
                new Claim("Familienaam", persoon.Familienaam),
                new Claim("Gebruikersnaam", persoon.UserName)
            };


            foreach (string roleName in roleNames)
            {
                claims.Add(new Claim(ClaimTypes.Role, roleName));
            }

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = "Opleiding web API",
                Subject = new ClaimsIdentity(claims.ToArray()),
                Expires = DateTime.UtcNow.AddSeconds(5), //TOKEN
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }



}
