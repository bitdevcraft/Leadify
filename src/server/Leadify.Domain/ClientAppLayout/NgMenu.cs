using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Leadify.Domain.ClientAppLayout;

[SuppressMessage("Design", "CA1056:URI-like properties should not be strings")]
public class NgMenu
{
    public Ulid Id { get; init; } = Ulid.NewUlid();
    public string? Label { get; set; }
    public string? Icon { get; set; }

    public string? RouterLinkArray { get; set; }

    [NotMapped]
    public string[]? RouterLink
    {
        get => RouterLinkArray?.Split(';');
        set => RouterLinkArray = value != null ? string.Join(";", value.Select(p => p.ToString()).ToArray()) : null;
    }

    public string? UrlArray { get; set; }

    [NotMapped]
    public string[]? Url
    {
        get => UrlArray?.Split(';');
        set => UrlArray = value != null ? string.Join(";", value.Select(p => p.ToString()).ToArray()) : null;
    }

    public NgMenu? Parent { get; set; }
    public Ulid? ParentId { get; set; }

    public ICollection<NgMenu>? Items { get; set; }

    [NotMapped] public ICollection<NgMenu>? Children { get; set; }
    [NotMapped] public Ulid? Key => Id;
    [NotMapped] public string? Data => Label;
    [NotMapped] public bool Droppable => RouterLinkArray is null && UrlArray is null;
    public int Hierarchy { get; set; }
}