using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class PlayerMatch
    {
        public string Id { get; private set; }
        public string Type { get; private set; }

        [JsonConstructor]
        private PlayerMatch(string id, string type)
        {
            Id = id;
            Type = type;
        }
    }
}
