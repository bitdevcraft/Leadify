using System.Collections.ObjectModel;
using Leadify.Domain.Users;

namespace Leadify.Domain.Metadata;

public class Workspace
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public string? DisplayName { get; set; }
    public string? Logo { get; set; }
    public string? DomainName { get; set; }
    public string? ConnectionString { get; set; }


    public Collection<User> Users { get; set; } = [];
}