using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class Team
    {
        public string Type { get; private set; }
        public string Id { get; private set; }

        [JsonConstructor]
        private Team(string type, string id)
        {
            Type = type;
            Id = id;
        }
    }
}
