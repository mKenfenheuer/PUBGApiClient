using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    public class SampleRelationships
    {
        public Match[] Matches { get; private set; }

        [JsonConstructor]
        private SampleRelationships(MatchData matches)
        {
            Matches = matches.Data;
        }
    }
}
