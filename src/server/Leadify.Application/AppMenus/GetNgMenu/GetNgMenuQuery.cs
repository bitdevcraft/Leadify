using Leadify.Application.Abstraction.Caching;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.ClientAppLayout;
using Leadify.Domain.Entities;
using Leadify.Domain.Extensions;

namespace Leadify.Application.AppMenus.GetNgMenu;

public record GetNgMenuQuery() : ICachedQuery<string>
{
    public string CacheKey => $"AppMenu-Root";
    public TimeSpan? Expiration => TimeSpan.FromMinutes(15);
}