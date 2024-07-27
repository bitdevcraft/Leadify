using Microsoft.Extensions.DependencyInjection;

namespace Leadify.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssembly(AssemblyReference.Assembly);
        });

        services.AddAutoMapper(AssemblyReference.Assembly);
        return services;
    }
}
