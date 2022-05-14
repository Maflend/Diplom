namespace Diplom.Client.Infrastructure.Services.Authentication
{
    /// <summary>
    /// Интерфейс сервиса для взаимодействия с токеном.
    /// </summary>
    public interface ITokenService
    {
        /// <summary>
        /// Получить токен.
        /// </summary>
        /// <returns></returns>
        Task<string> GetTokenAsync();

        /// <summary>
        /// Установить токен.
        /// </summary>
        /// <param name="token">Токен.</param>
        /// <returns></returns>
        Task SetTokenAsync(string token);

        /// <summary>
        /// Удалить токен.
        /// </summary>
        /// <returns></returns>
        Task DeleteTokenAsync();
    }
}
