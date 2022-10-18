namespace Diplom.Client.Infrastructure.Routes;

/// <summary>
/// Конечные точки контроллеря для аутентификации.
/// </summary>
public class AuthenticationEndpoints
{
    /// <summary>
    /// Конечная точка для регистрации.
    /// </summary>
    public readonly static string Register = "api/authentication/register";

    /// <summary>
    /// Конечная точка для авторизации.
    /// </summary>
    public readonly static string Login = "api/authentication/login";
}
