namespace Caching.Abstractions.Models;

public interface ICacheKey
{
    ScopeType ScopeType { get; }

    string CacheKey { get; }
}