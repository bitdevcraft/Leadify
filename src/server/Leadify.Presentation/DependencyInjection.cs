using Microsoft.Extensions.DependencyInjection;

namespace Leadify.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services
            .AddControllers()
            .AddApplicationPart(Leadify.Presentation.AssemblyReference.Assembly);
        return services;
    }
}
