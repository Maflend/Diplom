using Diplom.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace Diplom.AutoMapper;

public static class Module
{
    public static void ConfigureAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapperAssembly));
    }
}