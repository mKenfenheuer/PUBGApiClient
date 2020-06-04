using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class PlayerAttributes
    {
        public string Name { get; private set; }
        public string ShardId { get; private set; }
        /// <summary>
        /// Only filled if included by a leaderboard item.
        /// </summary>
        public PlayerStats Stats { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public string PatchVersion { get; private set; }
        public string TitleId { get; private set; }

        [JsonConstructor]
        private PlayerAttributes(string name, string shardId, PlayerStats stats, DateTime createdAt, DateTime updatedAt, string patchVersion, string titleId)
        {
            Name = name;
            ShardId = shardId;
            Stats = stats;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            PatchVersion = patchVersion;
            TitleId = titleId;
        }
    }
}
