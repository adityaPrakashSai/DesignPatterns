using System;
using Microsoft.Extensions.Caching.Memory;

//This class implements adapter pattern as it resolves incompatibity between
//ICacheStorage and IMemoryCache
//all that is left is to inject this in Customer Service
namespace Service
{
    public class MemoryCache : ICacheStorage
    {
        private IMemoryCache _cache;

        public MemoryCache()
        {
            this._cache = new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions());
        }
        public void Remove(string key)
        {
            this._cache.Remove(key);
        }

        public void Store<T>(string key, T data)
        {
            _cache.Set(key, data);
        }

        public T Retrieve<T>(string key)
        {
            bool found = _cache.TryGetValue(key, out var result);
            return (T) (found ? result : default(T));
        }
    }
}
