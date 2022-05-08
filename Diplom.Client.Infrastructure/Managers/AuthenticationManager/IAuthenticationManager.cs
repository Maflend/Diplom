using Diplom.API.Dto.Requests;

namespace Diplom.Client.Infrastructure.Managers.AuthenticationManager
{
    public interface IAuthenticationManager
    {
        Task<bool> Login(LoginRequestDto request);
        Task<bool> Register(RegisterRequestDto request);
        Task Logout();
        string ErrorMessage { get; set; }
    }
}
