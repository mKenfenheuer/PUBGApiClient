using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    [MaxRequestAge(60 * 15)]
    public class LifetimeStat
    {
        public string Type { get; private set; }
        public LifetimeStatAttributes Attributes { get; private set; }
        public StatRelationships Relationships { get; private set; }
        public ApiLink Links { get; private set; }

        [JsonConstructor]
        private LifetimeStat(string type, LifetimeStatAttributes attributes, StatRelationships relationships, ApiLink links)
        {
            Type = type;
            Attributes = attributes;
            Relationships = relationships;
            Links = links;
        }
    }
}
