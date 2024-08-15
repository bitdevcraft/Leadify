using Leadify.Domain.Users;
using Leadify.Persistence.UlidProperty;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Persistence;

public sealed class ApplicationDbContext : IdentityDbContext<User, Role, Ulid, IdentityUserClaim<Ulid>, UserRole, IdentityUserLogin<Ulid>,
        IdentityRoleClaim<Ulid>, IdentityUserToken<Ulid>>
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<Ulid>().HaveConversion<UlidToStringConverter>();
        //.HaveConversion<UlidToBytesConverter>();
    }
}
