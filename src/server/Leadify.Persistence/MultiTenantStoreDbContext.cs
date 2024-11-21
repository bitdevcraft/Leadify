using Finbuckle.MultiTenant;
using Finbuckle.MultiTenant.EntityFrameworkCore.Stores.EFCoreStore;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Persistence;

public class MultiTenantStoreDbContext : EFCoreStoreDbContext<WorkspaceInfo>
{
    public MultiTenantStoreDbContext(DbContextOptions<MultiTenantStoreDbContext> options)
        : base(options)
    {
    }
}