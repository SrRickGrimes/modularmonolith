using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Server.CrossCuttingConcerns.Interfaces;
using Server.Module1.Application;
using Server.Module1.EndPoints;
using Server.Module1.Infrastructure;

namespace Server.Module1.Module
{
    public sealed class ModuleInstaller : IModuleInstaller
    {
        public string Name => "Module1";

        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplication()
                .AddInfrastructure()
                .AddEndPoints();
        }

        public void Use(IHost host, IConfiguration configuration)
        {
            host.UseInfrastructure();
        }
    }
}
