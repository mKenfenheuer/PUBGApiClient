using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class PlayersData
    {
        public Player[] Data { get; private set; }

        [JsonConstructor]
        private PlayersData(Player[] data)
        {
            Data = data;
        }
    }
}
