using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    [MaxRequestAge(int.MaxValue)]
    public class Match
    {
        public string Type { get; private set; }
        public string Id { get; private set; }
        public MatchAttributes Attributes { get; private set; }
        public MatchRelationships Relationships { get; private set; }
        public ApiLink Links { get; private set; }

        [JsonConstructor]
        private Match(string type, string id, MatchAttributes attributes, MatchRelationships relationships, ApiLink links)
        {
            Type = type;
            Id = id;
            Attributes = attributes;
            Relationships = relationships;
            Links = links;
        }
    }
}
