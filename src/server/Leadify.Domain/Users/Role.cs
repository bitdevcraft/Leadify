
using Microsoft.AspNetCore.Identity;

namespace Leadify.Domain.Users;

public class Role : IdentityRole<Ulid>
{
    public Role()
    {
        Id = Ulid.NewUlid();
    }

    public virtual ICollection<UserRole> UserRoles { get; set; }
    public virtual ICollection<RolePermission> RolePermissions { get; set; }
}

