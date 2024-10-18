using Microsoft.AspNetCore.Identity;

namespace Leadify.Domain.Users;

public class UserRole : IdentityUserRole<Ulid>
{
    public virtual required User User { get; set; }
    public virtual required Role Role { get; set; }
}