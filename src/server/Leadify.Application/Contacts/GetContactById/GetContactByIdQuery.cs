using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Caching;
using Leadify.Application.Common.PermissionType;
using Leadify.Domain.Constants;
using Leadify.Domain.Entities;

namespace Leadify.Application.Contacts.GetContactById;

[Authorize(Permissions = PermissionType.Contacts.View, Roles = RoleNames.SystemAdministrator)]
public sealed record GetContactByIdQuery(Ulid Id) : ICachedQuery<Contact>
{
    public string CacheKey => $"contacts-{Id}";

    public TimeSpan? Expiration => null;
}