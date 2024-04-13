using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Module1.Infrastructure
{
    internal static class ServiceExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) 
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblies([typeof(IInfrastructure).Assembly]);
            });
            return services;
        }

        public static IHost UseInfrastructure(this IHost host)
        {
            return host;
        }
    }
}
