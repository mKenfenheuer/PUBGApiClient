using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class PlayerAssets
    {
        public PlayerAsset[] Data { get; private set; }

        [JsonConstructor]
        private PlayerAssets(PlayerAsset[] data)
        {
            Data = data;
        }
    }
}
