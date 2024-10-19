using Leadify.Application.Abstraction.Messaging;

namespace Leadify.Application.Abstraction.Caching;

public interface ICachedQuery<TResponse> : IQuery<TResponse>, ICachedQuery { }

public interface ICachedQuery
{
    string CacheKey { get; }

    TimeSpan? Expiration { get; }
}
