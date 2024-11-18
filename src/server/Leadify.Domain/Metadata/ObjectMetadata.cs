using System.Collections.ObjectModel;

namespace Leadify.Domain.Metadata;

public class ObjectMetadata
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public required string Name { get; set; }
    public bool IsCustom { get; set; }

    // Fields
    public Collection<FieldMetadata> Fields { get; set; } = [];

    // Workspace
    public Ulid WorkspaceId { get; set; }
    public Workspace? Workspace { get; set; }

    //Datasource
    public Ulid DataSourceId { get; set; }
    public DataSourceMetadata? DataSource { get; set; }
}