using Diplom.Application.Interfaces;
using Diplom.Domain.Entities;
using Diplom.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Diplom.Application.Models;
using Diplom.Application.Models.Requests;

namespace Diplom.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IDiplomContext _db;
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public AuthService(IDiplomContext db, IUserService userService, IConfiguration configuration)
        {
            _db = db;
            _userService = userService;
            _configuration = configuration;
        }
        public async Task<string> Login(LoginRequest request)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.UserName == request.UserName);

            if (user == null)
            {
                throw new Exception("Пользователь не найден");
            }

            if (!_userService.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                throw new Exception("Неверный пароль");
            }

            string token = CreateToken(user);
            return token;
        }

        public async Task<User> Register(RegisterRequest request)
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
                return user;
            }
            else
            {
                throw new Exception("Логин занят");
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
