using Leadify.Application.Abstraction.Caching;

namespace Leadify.Application.AppMenus.GetNgMenu;

public record GetNgMenuQuery() : ICachedQuery<string>
{
    public string CacheKey => $"AppMenu-Root";
    public TimeSpan? Expiration => TimeSpan.FromMinutes(15);
}