using Diplom.Application.Abstracts.IServices;
using Diplom.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Diplom.Application
{
    /// <summary>
    /// Класс внедрения зависимостей уровня Application
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Конфигурирование сервисов.
        /// </summary>
        /// <param name="services"></param>
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
