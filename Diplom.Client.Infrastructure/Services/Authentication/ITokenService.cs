namespace Diplom.Client.Infrastructure.Services.Authentication;

/// <summary>
/// Интерфейс сервиса для взаимодействия с токеном.
/// </summary>
public interface ITokenService
{
    /// <summary>
    /// Получить токен.
    /// </summary>
    Task<string> GetTokenAsync();

    /// <summary>
    /// Установить токен.
    /// </summary>
    /// <param name="token">Токен.</param>
    Task SetTokenAsync(string token);

    /// <summary>
    /// Удалить токен.
    /// </summary>
    Task DeleteTokenAsync();
}
