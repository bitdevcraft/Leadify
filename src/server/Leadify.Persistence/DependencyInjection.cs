using Leadify.Domain.Repositories;
using Leadify.Domain.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Leadify.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceService(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        // Setup the connection to the Database
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection"))
        );

        services.AddIdentityService(configuration);

        return services;
    }

    private static IServiceCollection AddIdentityService(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services
            .AddIdentityCore<User>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

        return services;
    }
}
