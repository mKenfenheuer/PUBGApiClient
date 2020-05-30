using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class TeamData
    {
        public Team Data { get; private set; }

        [JsonConstructor]
        private TeamData(Team data)
        {
            Data = data;
        }
    }
}
