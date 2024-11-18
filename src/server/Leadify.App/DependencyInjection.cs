using Leadify.Domain.Repositories;
using Leadify.Persistence.Repositories;

namespace Leadify.App;

internal static class DependencyInjection
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddRepositories();
        services.AddHttpContextAccessor();
        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IContactRepository, ContactRepository>();
        return services;
    }
}