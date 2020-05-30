using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class StatTier
    {
        public string Tier { get; private set; }
        public string SubTier { get; private set; }

        [JsonConstructor]
        private StatTier(string tier, string subTier)
        {
            Tier = tier;
            SubTier = subTier;
        }
    }
}
