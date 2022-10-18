using Diplom.Domain.Entities;
using System.Security.Claims;

namespace Diplom.Application.Abstracts.IServices;

/// <summary>
/// Интерфейс сервиса аутентификации.
/// </summary>
public interface IAuthenticationService
{
    /// <summary>
    /// Утверждения личности.
    /// </summary>
    ClaimsIdentity Claims { get; set; }

    /// <summary>
    /// Создать токен.
    /// </summary>
    /// <param name="user">Пользователь.</param>
    /// <returns><see cref="string"/></returns>
    string CreateToken(User user);
}
