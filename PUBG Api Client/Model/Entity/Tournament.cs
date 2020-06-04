using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    [MaxRequestAge(60 * 15)]
    public class Tournament
    {
        public string Type { get; private set; }
        public string Id { get; private set; }
        public TournamentRelationships Relationships { get; private set; }
        public ApiLink Links { get; private set; }

        [JsonConstructor]
        private Tournament(string type, string id, TournamentRelationships relationships, ApiLink links)
        {
            Type = type;
            Id = id;
            Relationships = relationships;
            Links = links;
        }
    }
}
