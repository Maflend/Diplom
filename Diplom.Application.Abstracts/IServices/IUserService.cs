namespace Diplom.Application.Abstracts.IServices;

/// <summary>
/// Интерфейс сервиса для пользователя.
/// </summary>
public interface IUserService
{
    /// <summary>
    /// Сгенерировать хэш пароля.
    /// </summary>
    /// <param name="password"></param>
    /// <param name="passwordHash"></param>
    /// <param name="passwordSalt"></param>
    void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);

    /// <summary>
    /// Проверить хэш пароля.
    /// </summary>
    /// <param name="password"></param>
    /// <param name="passwordHash"></param>
    /// <param name="passwordSalt"></param>
    /// <returns></returns>
    bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
}
