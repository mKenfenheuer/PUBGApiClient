using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class MatchAssetAttributes
    {
        public DateTimeOffset CreatedAt { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonConstructor]
        private MatchAssetAttributes(DateTimeOffset createdAt, [JsonProperty("URL")] Uri url, string name, string description)
        {
            CreatedAt = createdAt;
            Url = url;
            Name = name;
            Description = description;
        }
    }
}
