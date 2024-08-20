using Microsoft.EntityFrameworkCore;

namespace Leadify.Domain.Auditable;

public class EntityAuditInformation
{
    public required dynamic Entity { get; set; }
    public required string TableName { get; set; }

    public EntityState State { get; set; }

    public ICollection<AuditEntry> Changes { get; set; } = [];

    public bool IsDeleteChanged { get; set; }

    public string OperationType =>
        State switch
        {
            EntityState.Added => "Create",
            EntityState.Modified => "Update",
            _ => string.Empty,
        };
}
