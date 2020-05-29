using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class Participant
    {
        public string Type { get; private set; }
        public string Id { get; private set; }

        [JsonConstructor]
        private Participant(string type, string id)
        {
            Type = type;
            Id = id;
        }
    }
}
