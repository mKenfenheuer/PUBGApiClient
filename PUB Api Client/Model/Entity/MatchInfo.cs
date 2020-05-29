using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    [MaxRequestAge(int.MaxValue)]
    public class MatchInfo
    {
        
        public string CreatedAt { get; set; }        
        public long Duration { get; set; }        
        public string MatchType { get; set; }        
        public string GameMode { get; set; }        
        public string MapName { get; set; }        
        public bool IsCustomMatch { get; set; }        
        public string PatchVersion { get; set; }        
        public string SeasonState { get; set; }        
        public string ShardId { get; set; }                
        public Stats Stats { get; set; }        
        public Stats Tags { get; set; }        
        public string TitleId { get; set; }
    }
}
