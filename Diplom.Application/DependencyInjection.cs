using Diplom.Application.Abstracts.IServices;
using Diplom.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Diplom.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
