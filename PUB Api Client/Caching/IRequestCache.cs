using System;
using System.Threading.Tasks;

namespace PUBG.ApiClient.Caching
{
    public interface IRequestCache
    {
        Task<string> TryGetResponseFromCache(string requestUrl, TimeSpan maxAge);
        Task AddResponseToCache(string requestUrl, string response, DateTime requestTime);
    }
}
