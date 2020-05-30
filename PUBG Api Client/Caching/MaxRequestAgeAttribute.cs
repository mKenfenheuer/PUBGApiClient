using System;
using System.Collections.Generic;
using System.Text;

namespace PUBG.ApiClient.Caching
{
    public class MaxRequestAgeAttribute : Attribute
    {
        public long MaxRequestAgeInSeconds { get; private set; }

        public MaxRequestAgeAttribute(long maxRequestAgeInSeconds)
        {
            MaxRequestAgeInSeconds = maxRequestAgeInSeconds;
        }
    }
}
