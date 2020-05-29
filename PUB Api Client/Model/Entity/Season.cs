using Newtonsoft.Json;
using PUBG.ApiClient.Caching;
using System;

namespace PUBG.ApiClient.Model.Entity
{
    [MaxRequestAge(60 * 60 * 24)]
    public class Season
    {
        public string Type { get; private set; }
        public string Id { get; private set; }
        public SeasonAttributes Attributes { get; private set; }

        [JsonConstructor]
        private Season(string type, string id, SeasonAttributes attributes)
        {
            Type = type;
            Id = id;
            Attributes = attributes;
        }
    }
}
