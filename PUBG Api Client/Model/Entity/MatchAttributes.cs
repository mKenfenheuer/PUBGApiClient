using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    public class MatchAttributes
    {
        public string CreatedAt { get; private set; }
        public long Duration { get; private set; }
        public string MatchType { get; private set; }
        public string GameMode { get; private set; }
        public string MapName { get; private set; }
        public bool IsCustomMatch { get; private set; }
        public string PatchVersion { get; private set; }
        public string SeasonState { get; private set; }
        public string ShardId { get; private set; }
        public MatchStats Stats { get; private set; }
        public MatchTags Tags { get; private set; }
        public string TitleId { get; private set; }
        
        [JsonConstructor]
        private MatchAttributes(string createdAt, long duration, string matchType, string gameMode, string mapName, bool isCustomMatch, string patchVersion, string seasonState, string shardId, MatchStats stats, MatchTags tags, string titleId)
        {
            CreatedAt = createdAt;
            Duration = duration;
            MatchType = matchType;
            GameMode = gameMode;
            MapName = mapName;
            IsCustomMatch = isCustomMatch;
            PatchVersion = patchVersion;
            SeasonState = seasonState;
            ShardId = shardId;
            Stats = stats;
            Tags = tags;
            TitleId = titleId;
        }
    }
}
