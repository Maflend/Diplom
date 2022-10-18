using Diplom.API.Dto.Requests;

namespace Diplom.Client.Infrastructure.Managers.AuthenticationManager;

/// <summary>
/// Менеджер аутентификации.
/// </summary>
public interface IAuthenticationManager
{
    /// <summary>
    /// Сообщение ошибки.
    /// </summary>
    string ErrorMessage { get; set; }

    /// <summary>
    /// Запрос на авторизацию.
    /// </summary>
    /// <param name="request">Данные для авторизации.</param>
    Task<bool> Login(LoginRequestDto request);

    /// <summary>
    /// Запрос на регистрацию.
    /// </summary>
    /// <param name="request">Данные для регистрации.</param>
    Task<bool> Register(RegisterRequestDto request);

    /// <summary>
    /// Запрос на разлогирование.
    /// </summary>
    Task Logout();
}
