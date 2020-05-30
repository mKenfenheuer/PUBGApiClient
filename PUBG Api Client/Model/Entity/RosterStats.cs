using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class RosterStats
    {
        public long Rank { get; private set; }
        public long TeamId { get; private set; }

        [JsonConstructor]
        private RosterStats(long rank, long teamId)
        {
            Rank = rank;
            TeamId = teamId;
        }
    }
}
