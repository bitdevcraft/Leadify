using System.ComponentModel.DataAnnotations;
using Leadify.Domain.Primitives;

namespace Leadify.Domain.Users;

public class UserActivity : Entity
{
    public new Ulid Id { get; init; } = Ulid.NewUlid();
    public required User User { get; init; }
    public Ulid? UserId { get; init; }
    [MaxLength(50)] public string? ActivityType { get; init; }
    [MaxLength(255)] public string? ActivityData { get; init; }
    [MaxLength(50)] public string? IpAddress { get; init; }
    [MaxLength(50)] public string? DeviceInfo { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
}