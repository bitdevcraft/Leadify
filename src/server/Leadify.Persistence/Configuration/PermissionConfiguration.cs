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
        var permissions = new HashSet<Permission>
        {
            new Permission
            {
                Id = Ulid.Parse("00000000004YS4BQKB4DT7DH13"),
                Name = $"Permissions.Users.Create",
                NormalizedName = "Permissions.Users.Create".ToUpperInvariant(),
            },

            new Permission
            {
                Id = Ulid.Parse("0000000000GEDF9899Z64EFA9S"),
                Name = $"Permissions.Users.View",
                NormalizedName = "Permissions.Users.View".ToUpperInvariant(),
            },

            new Permission
            {
                Id = Ulid.Parse("00000000004P8QQ3TGZHAZG6S4"),
                Name = $"Permissions.Users.Edit",
                NormalizedName = "Permissions.Users.Edit".ToUpperInvariant(),
            },

            new Permission
            {
                Id = Ulid.Parse("0000000000KQEFJD2YSEP419FR"),
                Name = $"Permissions.Users.Delete",
                NormalizedName = "Permissions.Users.Delete".ToUpperInvariant(),
            },

            new Permission
            {
                Id = Ulid.Parse("0000000000RM77M5MAH0K8ZEEM"),
                Name = $"Permissions.Roles.Create",
                NormalizedName = "Permissions.Roles.Create".ToUpperInvariant(),
            },

            new Permission
            {
                Id = Ulid.Parse("00000000007WVG42QKK0NM9HF8"),
                Name = $"Permissions.Roles.View",
                NormalizedName = "Permissions.Roles.View".ToUpperInvariant(),
            },

            new Permission
            {
                Id = Ulid.Parse("0000000000FKQC7CSXBVDBF5FY"),
                Name = $"Permissions.Roles.Edit",
                NormalizedName = "Permissions.Roles.Edit".ToUpperInvariant(),
            },

            new Permission
            {
                Id = Ulid.Parse("0000000000ASTQJK9JP6GW3T5C"),
                Name = $"Permissions.Roles.Delete",
                NormalizedName = "Permissions.Roles.Delete".ToUpperInvariant(),
            },
        };


        builder.HasData(permissions);
    }
}