using Diplom.Domain.Repositories.Abstracts;
using Microsoft.Extensions.DependencyInjection;

namespace Diplom.Infrastructure.Repositories;

/// <summary>
/// Класс внедрения зависимостей.
/// </summary>
public static class Module
{
    /// <summary>
    /// Сконфигурировать репозитории.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/>.</param>
    public static void ConfigureRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<ISaleRepository, SaleRepository>();
    }
}
