using AprovacaoDigital.Application.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Concurrent;

public class MemoryCacheService : ICacheService
{
    private readonly IMemoryCache _memoryCache;
    private readonly ConcurrentDictionary<string, byte> _cacheKeys;

    public MemoryCacheService(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
        _cacheKeys = new ConcurrentDictionary<string, byte>();
    }

    public T Get<T>(string key)
    {
        return _memoryCache.TryGetValue(key, out T value) ? value : default;
    }

    public void Set<T>(string key, T value, TimeSpan expiration)
    {
        _memoryCache.Set(key, value, expiration);
        _cacheKeys[key] = 0; // Use 0 as a dummy value
    }

    public void Remove(string key)
    {
        _memoryCache.Remove(key);
        _cacheKeys.TryRemove(key, out _);
    }

    public void Clear(string prefix)
    {
        foreach (var key in _cacheKeys.Keys)
        {
            if (key.StartsWith(prefix))
            {
                _memoryCache.Remove(key);
                _cacheKeys.TryRemove(key, out _);
            }
        }
    }
}
