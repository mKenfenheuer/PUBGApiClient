using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class ParticipantsData
    {
        public Participant[] Data { get; private set; }

        [JsonConstructor]
        private ParticipantsData(Participant[] data)
        {
            Data = data;
        }
    }
}
