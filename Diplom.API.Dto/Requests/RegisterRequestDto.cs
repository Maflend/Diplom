using System.ComponentModel.DataAnnotations;

namespace Diplom.API.Dto.Requests;

/// <summary>
/// Dto для регистрации.
/// </summary>
public class RegisterRequestDto
{
    /// <summary>
    /// Имя пользователя.
    /// </summary>
    [Required(ErrorMessage = "Имя пользователя должно быть заполнено.")]
    [MinLength(6, ErrorMessage = "Минимальная имени пользователя  6 символов.")]
    public string UserName { get; set; }

    /// <summary>
    /// Возраст.
    /// </summary>
    [Required(ErrorMessage = "Возвраст должен быть заполнен.")]
    public int Age { get; set; }

    /// <summary>
    /// Пароль.
    /// </summary>
    [Required(ErrorMessage = "Пароль должен быть заполнен.")]
    [MinLength(6, ErrorMessage = "Минимальная длина пароля 6 символов.")]
    public string Password { get; set; }

    /// <summary>
    /// Подтверждение пароля.
    /// </summary>
    [Required(ErrorMessage = "Подтвердите пароль.")]
    [Compare(nameof(Password), ErrorMessage = "Пароли не совпадают.")]
    public string ConfirmPassword { get; set; }
}
