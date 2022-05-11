using Diplom.Client.Infrastructure.Authentication;
using Diplom.Client.Infrastructure.Managers.AuthenticationManager;
using Diplom.Client.Infrastructure.Managers.CategoryManager;
using Diplom.Client.Infrastructure.Managers.ProductManager;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace Diplom.Client.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddClientInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationManager, AuthenticationManager>();
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
        }
    }
}
