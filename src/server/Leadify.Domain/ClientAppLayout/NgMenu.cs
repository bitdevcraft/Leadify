using System.Diagnostics.CodeAnalysis;

namespace Leadify.Domain.ClientAppLayout;

[SuppressMessage("Design", "CA1056:URI-like properties should not be strings")]
public class NgMenu
{
    public Ulid Id { get; init; } = Ulid.NewUlid();
    public string? Label { get; set; }
    public string? Icon { get; set; }

    public string? RouterLinkArray { get; set; }

    public string[] RouterLink
    {
        get => RouterLinkArray is null ? [] : RouterLinkArray.Split(';');
        set => RouterLinkArray = string.Join(";", value.Select(p => p.ToString()).ToArray());
    }

    public string? UrlArray { get; set; }

    public string[] Url
    {
        get => UrlArray is null ? [] : UrlArray.Split(';');
        set => UrlArray = string.Join(";", value.Select(p => p.ToString()).ToArray());
    }

    public NgMenu? Parent { get; set; }
    public Ulid? ParentId { get; set; }

    public ICollection<NgMenu> Items { get; } = [];
}