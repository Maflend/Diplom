using Diplom.Domain.Repositories.Abstracts;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Infrastructure.Repositories
{
    public static class DependencyInjection
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
