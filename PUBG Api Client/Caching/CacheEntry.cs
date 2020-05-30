using System;
using System.Collections.Generic;
using System.Text;

namespace PUBG.ApiClient.Caching
{
    class CacheEntry
    {
        public string ResponseString { get; private set; }
        public DateTime RequestTime { get; private set; }

        public CacheEntry(string responseString, DateTime requestTime)
        {
            ResponseString = responseString;
            RequestTime = requestTime;
        }
    }
}
