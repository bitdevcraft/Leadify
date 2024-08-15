using Microsoft.AspNetCore.Identity;

namespace Leadify.Domain.Users;

public class User : IdentityUser<Ulid>
{
    public User()
    {
        Id = Ulid.NewUlid();
        SecurityStamp = Guid.NewGuid().ToString();
    }

    public virtual ICollection<UserRole> UserRoles { get; set; }
}
