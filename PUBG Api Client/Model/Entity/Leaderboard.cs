using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    [MaxRequestAge(60 * 60 * 2)]
    public class Leaderboard
    {
        public string Type { get; private set; }
        public string Id { get; private set; }
        public LeaderboardAttributes Attributes { get; private set; }
        public LeaderboardRelationships Relationships { get; private set; }
        public ApiLink Links { get; private set; }

        [JsonConstructor]
        private Leaderboard(string type, string id, LeaderboardAttributes attributes, LeaderboardRelationships relationships, ApiLink links)
        {
            Type = type;
            Id = id;
            Attributes = attributes;
            Relationships = relationships;
            Links = links;
        }
    }
}
