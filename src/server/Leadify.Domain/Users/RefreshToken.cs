using System.ComponentModel.DataAnnotations;
using Leadify.Domain.Primitives;

namespace Leadify.Domain.Users;

public class RefreshToken : Entity
{
    public new Ulid Id { get; init; } = Ulid.NewUlid();
    public User? User { get; init; }
    [MaxLength(50)] public string? Token { get; init; }
    public DateTime Expires { get; init; } = DateTime.UtcNow.AddDays(7);
    private bool IsExpired => DateTime.UtcNow >= Expires;
    public DateTime? Revoked { get; init; }
    public bool IsActive => Revoked == null && !IsExpired;
}