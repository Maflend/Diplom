using System.ComponentModel.DataAnnotations;

namespace Diplom.API.Dto.Requests
{
    /// <summary>
    /// Dto для регистрации.
    /// </summary>
    public class RegisterRequestDto
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        [Required]
        [MinLength(6)]
        public string UserName { get; set; }

        /// <summary>
        /// Возраст.
        /// </summary>
        [Required]
        public int Age { get; set; }

        /// <summary>
        /// Пароль.
        /// </summary>
        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        /// <summary>
        /// Подтверждение пароля.
        /// </summary>
        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
