using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class ParticipantAttributes
    {
        public ParticipantStats Stats { get; private set; }
        public string Actor { get; private set; }
        public string ShardId { get; private set; }

        [JsonConstructor]
        private ParticipantAttributes(ParticipantStats stats, string actor, string shardId)
        {
            Stats = stats;
            Actor = actor;
            ShardId = shardId;
        }
    }
}
