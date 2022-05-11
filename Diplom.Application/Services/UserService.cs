using Diplom.Application.Abstracts.IServices;
using System.Security.Cryptography;

namespace Diplom.Application.Services
{
    /// <summary>
    /// Сервис пользователя
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// Создать хэш пароля.
        /// </summary>
        /// <param name="password">Пароль</param>
        /// <param name="passwordHash">Хэш</param>
        /// <param name="passwordSalt">Соль</param>
        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        /// <summary>
        /// Проверить хэш пароля.
        /// </summary>
        /// <param name="password">Пароль</param>
        /// <param name="passwordHash">Хэш</param>
        /// <param name="passwordSalt">Соль</param>
        /// <returns><see cref="bool"/></returns>
        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computeHash.SequenceEqual(passwordHash);
            }
        }
    }
}
