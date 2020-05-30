using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class MatchAssetsData
    {
        public MatchAsset[] Data { get; private set; }

        [JsonConstructor]
        private MatchAssetsData(MatchAsset[] data)
        {
            Data = data;
        }
    }
}
