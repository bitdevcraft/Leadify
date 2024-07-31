using Leadify.Infrastructure.Security.OptionsSetup;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Leadify.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddAuthenticationServices(configuration);
        return services;
    }

    private static IServiceCollection AddAuthenticationServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.ConfigureOptions<JwtOptionsSetup>();
        services.ConfigureOptions<JwtBearerOptionsSetup>();

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();

        return services;
    }
}
