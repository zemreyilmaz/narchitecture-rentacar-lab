using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        var assembly = typeof(ApplicationServiceRegistration).Assembly;

        services.AddAutoMapper(x => x.AddMaps(assembly));
        
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            
        });
        return services;
    }
}