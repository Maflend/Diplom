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
        [Required(ErrorMessage ="Имя пользователя должно быть заполнено.")]
        public string UserName { get; set; }

        /// <summary>
        /// Пароль.
        /// </summary>
        [Required(ErrorMessage = "Пароль должен быть заполнен.")]
        public string Password { get; set; }
    }
}
