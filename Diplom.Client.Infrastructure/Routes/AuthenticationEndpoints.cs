namespace Diplom.Client.Infrastructure.Routes
{
    /// <summary>
    /// Конечные точки контроллеря для аутентификации.
    /// </summary>
    public class AuthenticationEndpoints
    {
        /// <summary>
        /// Конечная точка для регистрации.
        /// </summary>
        public static string Register = "api/authentication/register";

        /// <summary>
        /// Конечная точка для авторизации.
        /// </summary>
        public static string Login = "api/authentication/login";
    }
}
