using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    public class LeaderboardAttributes
    {
        public string GameMode { get; private set; }
        public string ShardId { get; private set; }
        public string TitleId { get; private set; }
        
        [JsonConstructor]
        private LeaderboardAttributes(string gameMode, string shardId, string titleId)
        {
            GameMode = gameMode;
            ShardId = shardId;
            TitleId = titleId;
        }
    }
}
