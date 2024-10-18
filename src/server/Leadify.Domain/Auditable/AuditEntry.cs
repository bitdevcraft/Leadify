using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leadify.Domain.Auditable;

public class AuditEntry
{
    public Ulid Id { get; set; }
    [MaxLength(100)]
    public string? FieldName { get; set; }
    [MaxLength(100)]
    public string? OldValue { get; set; }
    [MaxLength(100)]

    public string? NewValue { get; set; }

    [ForeignKey(nameof(Audit))] public int AuditId { get; set; }

    public Audit? Audit { get; set; }
}