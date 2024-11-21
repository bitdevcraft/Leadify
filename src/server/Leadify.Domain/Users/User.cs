using System.ComponentModel.DataAnnotations;
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

    public User? Manager { get; set; }
    public Ulid? ManagerId { get; set; }
    public ICollection<User>? Members { get; set; }


    [MaxLength(255)] public string? FirstName { get; set; }
    [MaxLength(255)] public string? LastName { get; set; }
    [MaxLength(255)] public string? MiddleName { get; set; }
    [MaxLength(255)] public string? Suffix { get; set; }
    [MaxLength(255)] public string? Salutation { get; set; }
    [MaxLength(255)] public string? Mobile { get; set; }
    [MaxLength(255)] public string? Phone { get; set; }
    [MaxLength(255)] public string? Fax { get; set; }
    [MaxLength(255)] public string? Title { get; set; }
    public bool Active { get; set; } = true;
}