using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class PlayerData
    {
        public Player Data { get; private set; }

        [JsonConstructor]
        private PlayerData(Player data)
        {
            Data = data;
        }
    }
}
