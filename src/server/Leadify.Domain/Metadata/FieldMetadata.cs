namespace Leadify.Domain.Metadata;

public class FieldMetadata
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public required string Name { get; set; }
    public bool IsCustom { get; set; }
    public required string Type { get; set; }
    public bool IsRequired { get; set; }
    public string? ReferenceTo { get; set; }

    public int Precision { get; set; }

    public Ulid WorkspaceId { get; set; }
    public Workspace? Workspace { get; set; }
}