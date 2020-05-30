using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class Participant
    {
        public string Type { get; private set; }
        public string Id { get; private set; }
        public ParticipantAttributes Attributes { get; private set; }

        [JsonConstructor]
        private Participant(string type, string id, ParticipantAttributes attributes)
        {
            Type = type;
            Id = id;
            Attributes = attributes;
        }
    }
}
