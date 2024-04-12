using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Server.CrossCuttingConcerns.Interfaces;
using Server.Feedback.Application;
using Server.Feedback.EndPoints;
using Server.Feedback.Infrastructure;

namespace Server.Feedback.Module
{
    public sealed class ModuleInstaller : IModuleInstaller
    {
        public string Name => "Feedback";

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
