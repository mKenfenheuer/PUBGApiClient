using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    public class TournamentRelationships
    {
        /// <summary>
        /// Only filled with type and id when getting the list of tournaments. You need to lookup the match using <c>PUBGApiClient.GetMatch(string shard, string matchId)</c>.
        /// </summary>
        public Match[] Matches { get; private set; }

        [JsonConstructor]
        private TournamentRelationships(ApiData<Match[]> matches)
        {
            Matches = matches.Data;
        }
    }
}
