using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUBG.ApiClient.Caching
{
    public class NoRequestCache : IRequestCache
    {
        #pragma warning disable CS1998
        public async Task AddResponseToCache(string requestUrl, string response, DateTime requestTime)
        {
            //Do nothing
        }

        public async Task<string> TryGetResponseFromCache(string requestUrl, TimeSpan maxAge)
        {
            //Always return null to disable caching
            return null;
        }
        #pragma warning restore CS1998
    }
}
