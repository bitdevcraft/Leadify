using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leadify.Domain.Auditable;

public class AuditEntry
{
    public Ulid Id { get; set; }
    public string? FieldName { get; set; }

    public string? OldValue { get; set; }
    public string? NewValue { get; set; }

    [ForeignKey(nameof(Audit))]
    public int AuditId { get; set; }
    public Audit Audit { get; set; }
}
