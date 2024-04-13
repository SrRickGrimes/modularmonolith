using FastEndpoints;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Module1.EndPoints
{
    internal static class ServiceExtensions
    {
        public static IServiceCollection AddEndPoints(this IServiceCollection services) 
        {
            services.AddFastEndpoints(config =>
            {
                config.SourceGeneratorDiscoveredTypes.AddRange(DiscoveredTypes.All);
            });
            return services;
        }
    }
}
