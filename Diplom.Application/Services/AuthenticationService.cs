using Diplom.Application.Abstracts.IServices;
using Diplom.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Diplom.Application.Services
{
    /// <summary>
    /// Сервис аутентификации.
    /// </summary>
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IConfiguration _configuration;

        public AuthenticationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Утверждения пользователя.
        /// </summary>
        public ClaimsIdentity Claims { get; set; } = new();

        /// <summary>
        /// Создать токен.
        /// </summary>
        /// <param name="user"><see cref="User"/></param>
        /// <returns><see cref="string"/></returns>
        public string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };
            Claims = new ClaimsIdentity(claims);
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
