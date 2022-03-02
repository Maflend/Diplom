using Diplom.Client.Infrastructure.Managers.AuthenticationManager;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Client.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddClientInfrastructure( this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationManager, AuthenticationManager>();
        }
    }
}
