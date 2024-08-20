using System.Buffers;
using System.Text.Json;
using AutoMapper.Execution;
using Leadify.Application.Abstraction.Caching;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace Leadify.Infrastructure.Caching;

internal sealed class CacheService(IDistributedCache cache) : ICacheService
{
    private readonly IDistributedCache _cache = cache;

    public async Task<T?> GetAsync<T>(string key, CancellationToken cancellation = default)
    {
        string? bytes = await _cache.GetStringAsync(key, cancellation);

        return bytes is null ? default : Deserialize<T>(bytes);
    }

    private static T? Deserialize<T>(string bytes)
    {
        var result = JsonConvert.DeserializeObject<T>(
            bytes,
            new JsonSerializerSettings
            {
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                ContractResolver = new PrivateResolver()
            }
        );

        return result is null ? default : result;
    }

    public Task RemoveAsync(string key, CancellationToken cancellationToken = default)
    {
        return _cache.RemoveAsync(key, cancellationToken);
    }

    public Task SetAsync<T>(
        string key,
        T value,
        TimeSpan? expiration = null,
        CancellationToken cancellationToken = default
    )
    {
        string bytes = JsonConvert.SerializeObject(value);

        return _cache.SetStringAsync(
            key,
            bytes,
            CacheOptions.Create(expiration),
            cancellationToken
        );
    }
}
