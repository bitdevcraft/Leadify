namespace Leadify.Domain.Metadata;

public class DataSourceMetadata
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public required string Name { get; set; }
    public required string Schema { get; set; }
    public required string Type { get; set; }
    public bool IsRemote { get; set; }
    public Uri? Url { get; set; }

    public Ulid WorkspaceId { get; set; }
    public Workspace? Workspace { get; set; }
}