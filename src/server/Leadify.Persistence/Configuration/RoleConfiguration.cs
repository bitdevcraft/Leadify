using Leadify.Domain.Constants;
using Leadify.Domain.Users;
using Leadify.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leadify.Persistence.Configuration;

internal class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable(TableNames.SysRoles);

        // Each User can have many entries in the UserRole join table
        builder
            .HasMany(e => e.UserRoles)
            .WithOne(e => e.Role)
            .HasForeignKey(ur => ur.RoleId)
            .IsRequired();

        // Each Role can have many entries in the RolePermission join table
        builder
            .HasMany(e => e.RolePermissions)
            .WithOne(e => e.Role)
            .HasForeignKey(ur => ur.RoleId)
            .IsRequired();

        // Default Roles
        var defaultRoleNames = new List<string>
        {
            RoleNames.SystemAdministrator,
            RoleNames.Administrator,
            RoleNames.User
        };

        var roles = new List<Role>();
        foreach (string item in defaultRoleNames)
        {
            roles.Add(new Role(item) { NormalizedName = item.ToUpperInvariant() });
        }

        //Seed Default Roles Data
        builder.HasData(roles);
    }
}