using Leadify.Domain.Users;
using Leadify.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leadify.Persistence.Configuration;

internal class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.ToTable(TableNames.SysPermissions);

        // Primary key
        builder.HasKey(r => r.Id);

        // Index for "normalized" role name to allow efficient lookups
        builder.HasIndex(r => r.NormalizedName).HasDatabaseName("PermissionNameIndex").IsUnique();

        // A concurrency token for use with the optimistic concurrency checking
        builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

        // Limit the size of columns to use efficient database types
        builder.Property(u => u.Name).HasMaxLength(256);
        builder.Property(u => u.NormalizedName).HasMaxLength(256);

        // Each Role can have many entries in the RolePermission join table
        builder
            .HasMany(e => e.RolePermissions)
            .WithOne(e => e.Permission)
            .HasForeignKey(ur => ur.PermissionId)
            .IsRequired();

        // Seed Data

        string[] modules = ["Contacts", "Users", "Roles"];
        var permissions = new HashSet<Permission>();

        foreach (string item in modules)
        {
            ICollection<string> tmpPermissions = Permissions.GeneratePermissionsForModule(item);

            foreach (string permissionName in tmpPermissions)
            {
                permissions.Add(
                    new Permission(permissionName)
                    {
                        NormalizedName = permissionName.ToUpperInvariant()
                    }
                );
            }
        }

        builder.HasData(permissions);
    }
}