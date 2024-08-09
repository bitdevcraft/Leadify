using Leadify.Application.Abstraction.Caching;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;

namespace Leadify.Application.Contacts.GetContactById;

public sealed record GetContactByIdQuery(Ulid Id) : ICachedQuery<Contact>
{
    public string CacheKey => $"contacts-{Id}";

    public TimeSpan? Expiration => null;
}
