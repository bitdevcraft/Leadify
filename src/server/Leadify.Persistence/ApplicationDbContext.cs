using Finbuckle.MultiTenant;
using Finbuckle.MultiTenant.Abstractions;
using Finbuckle.MultiTenant.EntityFrameworkCore;
using Finbuckle.MultiTenant.EntityFrameworkCore.Stores.EFCoreStore;
using Leadify.Domain.Users;
using Leadify.Persistence.UlidProperty;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Persistence;

public sealed class ApplicationDbContext
    : MultiTenantIdentityDbContext<
        User,
        Role,
        Ulid,
        IdentityUserClaim<Ulid>,
        UserRole,
        IdentityUserLogin<Ulid>,
        IdentityRoleClaim<Ulid>,
        IdentityUserToken<Ulid>
    >
{
    // AppTenantInfo is the app's custom implementation of ITenantInfo which 
    private new WorkspaceInfo? WorkspaceInfo { get; set; }

    public ApplicationDbContext(IMultiTenantContextAccessor<WorkspaceInfo> multiTenantContextAccessor,
        DbContextOptions<ApplicationDbContext> options) :
        base(multiTenantContextAccessor, options) =>
        WorkspaceInfo = multiTenantContextAccessor.MultiTenantContext.TenantInfo;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
    }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        this.EnforceMultiTenant();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        this.EnforceMultiTenant();
        return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder) =>
        configurationBuilder.Properties<Ulid>().HaveConversion<UlidToStringConverter>();
}