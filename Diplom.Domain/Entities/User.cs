using Diplom.Domain.Entities.Base;
using Diplom.Domain.Enums;

namespace Diplom.Domain.Entities
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Роль.
        /// </summary>
        public RoleEnum Role { get; set; }

        /// <summary>
        /// Возраст.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Хэш пароля.
        /// </summary>
        public byte[] PasswordHash { get; set; }

        /// <summary>
        /// Соль пароля.
        /// </summary>
        public byte[] PasswordSalt { get; set; }

        /// <summary>
        /// Заказы.
        /// </summary>
        public List<Order> Orders { get; set; }
    }
}
