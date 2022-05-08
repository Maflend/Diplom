using Diplom.Application.Abstracts.IServices;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;
using Diplom.Application.Exeptions;
using Diplom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;


namespace Diplom.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IDiplomContext _db;
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public AuthenticationService(IDiplomContext db, IUserService userService, IConfiguration configuration)
        {
            _db = db;
            _userService = userService;
            _configuration = configuration;
        }
        public async Task<string> LoginAsync(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.UserName == request.UserName);

            if (user == null)
            {
                throw new ServiceException("Пользователь не найден", ServiceExceptionType.NotFound);
            }

            if (!_userService.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                throw new ServiceException("Неверный пароль", ServiceExceptionType.BadRequest);
            }

            string token = CreateToken(user);
            return token;
        }

        public async Task RegisterAsync(RegisterCommand request, CancellationToken cancellationToken)
        {
            if (!_db.Users.Any(u => u.UserName == request.UserName))
            {
                _userService.CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
                User user = new User();
                user.Role = "Client";
                user.Age = request.Age;
                user.UserName = request.UserName;
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                _db.Users.Add(user);
                await _db.SaveChangesAsync(new CancellationToken());
            }
            else
            {
                throw new ServiceException("Логин занят", ServiceExceptionType.BadRequest);
            }

        }

        public ClaimsIdentity Claims { get; set; } = new();

        public string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.Role)
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
