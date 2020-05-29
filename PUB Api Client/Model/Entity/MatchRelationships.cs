using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    public class MatchRelationships
    {
        public MatchAsset[] MatchAssets { get; private set; }
        public Roster[] Rosters { get; private set; }
        public Round[] Rounds { get; private set; }
        public Spectator[] Spectators { get; private set; }

        public MatchRelationships(MatchAssetsData assets, RostersData rosters, Round[] rounds, Spectator[] spectators)
        {
            MatchAssets = assets.Data;
            Rosters = rosters.Data;
            Rounds = rounds;
            Spectators = spectators;
        }
    }
}
