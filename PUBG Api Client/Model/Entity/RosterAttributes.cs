using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class RosterAttributes
    {
        public RosterStats Stats { get; private set; }
        public bool Won { get; private set; }
        public string ShardId { get; private set; }

        [JsonConstructor]
        private RosterAttributes(RosterStats stats, bool won, string shardId)
        {
            Stats = stats;
            Won = won;
            ShardId = shardId;
        }
    }
}
