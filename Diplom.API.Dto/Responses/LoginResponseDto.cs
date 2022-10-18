namespace Diplom.API.Dto.Responses;

/// <summary>
/// Dto авторизации для ответа сервера.
/// </summary>
public class LoginResponseDto
{
    /// <summary>
    /// Токен.
    /// </summary>
    public string Token { get; set; }
}
