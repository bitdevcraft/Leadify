using Microsoft.Extensions.DependencyInjection;

namespace Leadify.Presentation;

/// <summary>
/// 
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        _ = services
            .AddControllers()
            .AddApplicationPart(Leadify.Presentation.AssemblyReference.Assembly);
        return services;
    }
}