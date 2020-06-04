using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    public class SampleAttributes
    {
        public string CreatedAt { get; private set; }
        public string ShardId { get; private set; }
        public string TitleId { get; private set; }
        
        [JsonConstructor]
        private SampleAttributes(string createdAt, string shardId, string titleId)
        {
            CreatedAt = createdAt;
            ShardId = shardId;
            TitleId = titleId;
        }
    }
}
