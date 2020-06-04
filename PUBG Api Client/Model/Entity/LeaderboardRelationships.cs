using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    public class LeaderboardRelationships
    {
        public Player[] Players { get; private set; }

        [JsonConstructor]
        private LeaderboardRelationships(ApiData<Player[]> players)
        {
            Players = players.Data;
        }
    }
}
