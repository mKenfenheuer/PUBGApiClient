using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class MatchAsset
    {
        public string Type { get; private set; }
        public string Id { get; private set; }
        public MatchAssetAttributes Attributes { get; private set; }

        [JsonConstructor]
        private MatchAsset(string type, string id, MatchAssetAttributes attributes)
        {
            Type = type;
            Id = id;
            Attributes = attributes;
        }
    }
}
