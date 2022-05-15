using Diplom.Client.Infrastructure.Authentication;
using Diplom.Client.Infrastructure.Managers.AuthenticationManager;
using Diplom.Client.Infrastructure.Managers.CategoryManager;
using Diplom.Client.Infrastructure.Managers.OrderManager;
using Diplom.Client.Infrastructure.Managers.ProductManager;
using Diplom.Client.Infrastructure.Services.Authentication;
using Diplom.Client.Infrastructure.Services.Cart;
using Diplom.Client.Infrastructure.Services.Http;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace Diplom.Client.Infrastructure
{
    /// <summary>
    /// Класс для внедрения зависимостей.
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Сконфигурировать инфраструктура клиета.
        /// </summary>
        /// <param name="services"></param>
        public static void AddClientInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationManager, AuthenticationManager>();
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IOrderManager, OrderManager>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ICartService, CartService>();

         
        }
    }
}
