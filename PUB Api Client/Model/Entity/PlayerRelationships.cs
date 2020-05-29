using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class PlayerRelationships
    {
        public PlayerAsset[] Assets { get; private set; }
        public PlayerMatch[] Matches { get; private set; }

        [JsonConstructor]
        private PlayerRelationships(PlayerAssets assets, PlayerMatches matches)
        {
            Assets = assets.Data;
            Matches = matches.Data;
        }
    }
}
