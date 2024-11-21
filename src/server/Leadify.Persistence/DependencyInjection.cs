using Finbuckle.MultiTenant;
using Leadify.Domain.System;
using Leadify.Domain.Users;
using Leadify.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TenantInfo = Finbuckle.MultiTenant.TenantInfo;

namespace Leadify.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceService(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        // Set up the connection to the Database
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
                .ConfigureWarnings(warnings => warnings.Log(RelationalEventId.PendingModelChangesWarning))
        );

        // Set up the connection to the Database
        services.AddDbContext<MultiTenantStoreDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
                .ConfigureWarnings(warnings => warnings.Log(RelationalEventId.PendingModelChangesWarning))
        );

        services.AddIdentityService(configuration);
        services.AddMultiTenantService();
        services.AddScoped<ApplicationDbContextInitialiser>();

        return services;
    }

    private static IServiceCollection AddIdentityService(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services
            .AddIdentityCore<User>()
            .AddRoles<Role>()
            .AddEntityFrameworkStores<ApplicationDbContext>();


        return services;
    }

    private static IServiceCollection AddMultiTenantService(
        this IServiceCollection services
    )
    {
        services
            .AddMultiTenant<WorkspaceInfo>()
            .WithHeaderStrategy("tenant")
            .WithEFCoreStore<MultiTenantStoreDbContext, WorkspaceInfo>();

        return services;
    }
}