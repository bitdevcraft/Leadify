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


        var roles = new List<Role>
        {
            new Role
            {
                Id = Ulid.Parse("0000000000WV15C9SJMC7SW5RS"),
                Name = RoleNames.SystemAdministrator,
                NormalizedName = RoleNames.SystemAdministrator.ToUpperInvariant(),
            },

            new Role
            {
                Id = Ulid.Parse("0000000000TY56CFK2QP0MMBGT"),
                Name = RoleNames.Administrator,
                NormalizedName = RoleNames.Administrator.ToUpperInvariant(),
            },

            new Role
            {
                Id = Ulid.Parse("000000000062MV1SKKWKYF6JHY"),
                Name = RoleNames.User,
                NormalizedName = RoleNames.User.ToUpperInvariant(),
            },
        };


        //Seed Default Roles Data
        builder.HasData(roles);
    }
}