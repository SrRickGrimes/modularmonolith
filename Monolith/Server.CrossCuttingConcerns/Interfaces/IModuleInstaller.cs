using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Server.CrossCuttingConcerns.Interfaces
{
    public interface IModuleInstaller
    {
        public string Name { get; }

        void Install(IServiceCollection services,IConfiguration configuration);

        void Use(IHost host, IConfiguration configuration);
    }
}
