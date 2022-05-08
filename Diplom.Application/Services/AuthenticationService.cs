using Diplom.Application.Abstracts.IServices;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;
using Diplom.Application.Exeptions;
using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Infrastructure.Specifications.UserSpecifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;


namespace Diplom.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public AuthenticationService(IUserRepository userRepository, IUserService userService, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _userService = userService;
            _configuration = configuration;
        }
        public async Task<string> LoginAsync(LoginCommand request, CancellationToken cancellationToken)
        {
            // var user = await _db.Users.FirstOrDefaultAsync(u => u.UserName == request.UserName);
            var user = await _userRepository.GetBySpecAsync(new GetUserByUserNameSpec(request.UserName), cancellationToken);

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
            if (! await _userRepository.AnyAsync(u => u.UserName == request.UserName, cancellationToken))
            {
                _userService.CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
                User user = new User();
                user.Role = "Client";
                user.Age = request.Age;
                user.UserName = request.UserName;
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                await _userRepository.AddAndSaveAsync(user, cancellationToken);
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
