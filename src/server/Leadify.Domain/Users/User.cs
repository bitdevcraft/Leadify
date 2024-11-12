using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;

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

    public User? Manager { get; set; }
    public Ulid? ManagerId { get; set; }
    public ICollection<User>? Members { get; set; }


    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}

// TODO : Add a IsInternal / IsExternal property to identity the user