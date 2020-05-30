using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUBG.ApiClient.Caching
{
    public class InMemoryRequestCache : IRequestCache
    {
        private Dictionary<string, CacheEntry> cache = new Dictionary<string, CacheEntry>();

        #pragma warning disable CS1998
        public async Task AddResponseToCache(string requestUrl, string response, DateTime requestTime)
        {
            cache[requestUrl] = new CacheEntry(response, requestTime);
        }

        public async Task<string> TryGetResponseFromCache(string requestUrl, TimeSpan maxAge)
        {
            if (!cache.ContainsKey(requestUrl) || cache[requestUrl].RequestTime - DateTime.UtcNow < -maxAge)
                return null;
            return cache[requestUrl].ResponseString;
        }
        #pragma warning restore CS1998
    }
}
