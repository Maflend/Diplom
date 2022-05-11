using System.ComponentModel.DataAnnotations;

namespace Diplom.API.Dto.Requests
{
    /// <summary>
    /// Dto для авторизации.
    /// </summary>
    public class LoginRequestDto
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// Пароль.
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}
