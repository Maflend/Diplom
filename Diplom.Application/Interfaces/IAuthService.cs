using Diplom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Diplom.Application.Models.Requests;

namespace Diplom.Domain.Interfaces
{
    public interface IAuthService
    {
        ClaimsIdentity Claims { get; set; }
        string CreateToken(User user);
        Task<string> Login(LoginRequest request);
        Task<User> Register(RegisterRequest request);

    }
}
