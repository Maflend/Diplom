﻿using Diplom.Application.Abstracts.IServices;
using Diplom.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Diplom.Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DiplomContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(DiplomContext).Assembly.FullName)));

            services.AddScoped<IDiplomContext>(provider => provider.GetService<DiplomContext>());
        }
    }
}
