using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class PlayerMatches
    {
        public PlayerMatch[] Data { get; private set; }

        [JsonConstructor]
        private PlayerMatches(PlayerMatch[] data)
        {
            Data = data;
        }
    }
}
