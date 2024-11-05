using System.ComponentModel.DataAnnotations.Schema;

namespace Leadify.Domain.Auditable;

public class AuditEntry
{
    public Ulid Id { get; init; }
    public string? FieldName { get; init; }

    public string? OldValue { get; init; }
    public string? NewValue { get; init; }

    [ForeignKey(nameof(Audit))] public int AuditId { get; init; }
    public Audit? Audit { get; init; }
}