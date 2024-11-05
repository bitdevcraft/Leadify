using Microsoft.AspNetCore.Identity;

namespace Leadify.Domain.Users;

public class User : IdentityUser<Ulid>
{
    public User()
    {
        Id = Ulid.NewUlid();
        SecurityStamp = Guid.NewGuid().ToString();
    }

    public virtual ICollection<UserRole> UserRoles { get; set; } = [];
    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = [];
    public virtual ICollection<UserActivity> UserActivities { get; set; } = [];
}

// TODO : Create a self referencing to have a hierarchy style
// TODO : Add a IsInternal / IsExternal property to identity the user