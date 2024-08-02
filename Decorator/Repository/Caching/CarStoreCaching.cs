using System;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace Decorator.Repository.Caching
{
    public class CarStoreCaching : ICarStore
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ICarStore _inner;
        private readonly ILogger<CarStoreCaching> _logger;

        public CarStoreCaching(IMemoryCache memoryCache, ICarStore inner, ILogger<CarStoreCaching> logger)
        {
            _memoryCache = memoryCache;
            _inner = inner;
            _logger = logger;
        }
        public CarDto GetCars()
        {
            var key = "Cars";
            var items = _memoryCache.Get<CarDto>(key);
            if (items == null)
            {
                items = _inner.GetCars();
                _logger.LogTrace("Cache miss for {CacheKey}", key);
                if (items != null)
                {
                    _logger.LogTrace("Setting items in cache for {CacheKey}", key);
                    _memoryCache.Set(key, items, TimeSpan.FromMinutes(1));
                }
            }
            else
            {
                items.FromMemory();
                _logger.LogTrace("Cache hit for {CacheKey}", key);
            }

            return items;
        }

        public CarDto GetCarById(int id)
        {
            var key = $"Cars:{id}";
            var items = _memoryCache.Get<CarDto>(key);
            if (items == null)
            {
                items = _inner.GetCarById(id);
                _logger.LogTrace("Cache miss for {CacheKey}", key);
                if (items != null)
                {
                    _logger.LogTrace("Setting items in cache for {CacheKey}", key);
                    _memoryCache.Set(key, items, TimeSpan.FromMinutes(1));
                }
            }
            else
            {
                items.FromMemory();
                _logger.LogTrace("Cache hit for {CacheKey}", key);
            }

            return items;
        }
    }
}
