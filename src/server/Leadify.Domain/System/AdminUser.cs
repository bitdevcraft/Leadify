using Microsoft.AspNetCore.Identity;

namespace Leadify.Domain.System;

public class AdminUser : IdentityUser<Ulid>
{
    public AdminUser()
    {
        Id = Ulid.NewUlid();
        SecurityStamp = Guid.NewGuid().ToString();
    }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public AdminUser? CreatedBy { get; set; }
    public Ulid? CreatedById { get; set; }
}