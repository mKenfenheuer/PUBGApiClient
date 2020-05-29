using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class PlayerAsset
    {
        public string Id { get; private set; }
        public string Type { get; private set; }

        [JsonConstructor]
        private PlayerAsset(string id, string type)
        {
            Id = id;
            Type = type;
        }
    }
}
