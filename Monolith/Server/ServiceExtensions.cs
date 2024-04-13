using Server.CrossCuttingConcerns.Interfaces;

namespace Server.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection InstallModules(this IServiceCollection services)
        {
            services.Scan(scan => scan
                .FromApplicationDependencies()
                .AddClasses(classes => classes.AssignableTo<IModuleInstaller>())
                .AsImplementedInterfaces()
                .WithSingletonLifetime());

            return services;
        }

        public static IServiceCollection ConfigureModules(this IServiceCollection services, IConfiguration configuration)
        {
            using var serviceProvider = services.BuildServiceProvider();
            var modules = serviceProvider.GetRequiredService<IEnumerable<IModuleInstaller>>();
            foreach (var module in modules)
            {
                module.Install(services, configuration);
            }

            return services;
        }

        public static IHost UseModules(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            var modules = scope.ServiceProvider.GetRequiredService<IEnumerable<IModuleInstaller>>();
            var configuration = scope.ServiceProvider.GetRequiredService<IConfiguration>();
            foreach (var module in modules)
            {
                module.Use(host, configuration);
            }

            return host;
        }
    }

}
