using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    [MaxRequestAge(60 * 15)]
    public class Player
    {
        public string Type { get; private set; }
        public string Id { get; private set; }
        public PlayerAttributes Attributes { get; private set; }
        public PlayerRelationships Relationships { get; private set; }
        public ApiLink Links { get; private set; }

        [JsonConstructor]
        private Player(string type, string id, PlayerAttributes attributes, PlayerRelationships relationships, ApiLink links)
        {
            Type = type;
            Id = id;
            Attributes = attributes;
            Relationships = relationships;
            Links = links;
        }
    }
}
