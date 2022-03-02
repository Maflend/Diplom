using Diplom.Application.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Client.Infrastructure.Managers.AuthenticationManager
{
    public interface IAuthenticationManager
    {
        Task<bool> Login(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        Task Logout();
        string ErrorMessage { get; set; }
    }
}
