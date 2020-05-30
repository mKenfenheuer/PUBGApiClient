using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class RostersData
    {
        public Roster[] Data { get; private set; }

        [JsonConstructor]
        private RostersData(Roster[] data)
        {
            Data = data;
        }
    }
}
