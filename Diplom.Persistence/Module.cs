using Diplom.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Diplom.Persistence
{
    /// <summary>
    /// Класс внедрения зависимостей уровня Persistence.
    /// </summary>
    public static class Module
    {
        /// <summary>
        /// Конфигурирование контекста.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DiplomContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(DiplomContext).Assembly.FullName)));
        }
    }
}
