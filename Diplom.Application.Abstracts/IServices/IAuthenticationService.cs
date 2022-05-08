using Diplom.Application.Abstracts.Mediator.Authentication.Commands;
using Diplom.Domain.Entities;
using System.Security.Claims;

namespace Diplom.Application.Abstracts.IServices
{
    public interface IAuthenticationService
    {
        ClaimsIdentity Claims { get; set; }
        string CreateToken(User user);
        Task<string> LoginAsync(LoginCommand request);
        Task RegisterAsync(RegisterCommand request);

    }
}
