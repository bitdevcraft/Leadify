namespace Leadify.Domain.ClientAppLayout;

public class NgFormLayout
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string? Name { get; set; }
    public string? SmallText { get; set; }
    public string? Placeholder { get; set; }
    public string? Type { get; set; }
    public string? ObjectType { get; set; }
    public bool Required { get; set; }
    public bool ReadOnly { get; set; }
}