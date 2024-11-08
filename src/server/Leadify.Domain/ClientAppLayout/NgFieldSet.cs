namespace Leadify.Domain.ClientAppLayout;

public class NgFieldSet
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public required string ObjectName { get; set; }
    public required string FieldNames { get; set; }
}