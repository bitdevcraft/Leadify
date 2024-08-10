using Microsoft.EntityFrameworkCore;

namespace Leadify.Domain.Auditable;

public class EntityAuditInformation
{
    public dynamic Entity { get; set; }
    public string TableName { get; set; }

    public EntityState State { get; set; }

    public List<AuditEntry> Changes { get; set; }

    public bool IsDeleteChanged { get; set; }

    public string OperationType
    {
        get
        {
            switch (State)
            {
                case EntityState.Added:
                    return "Create";
                case EntityState.Modified:
                    return "Update";
                default:
                    return string.Empty;
            }
        }
    }
}
