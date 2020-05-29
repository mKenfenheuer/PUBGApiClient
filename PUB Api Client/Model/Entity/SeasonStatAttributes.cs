using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class SeasonStatAttributes
    {
        public GameModeStat<RankedGameModeStat> RankedGameModeStats { get; private set; }
        public GameModeStat<NormalGameModeStat> GameModeStats { get; private set; }


        [JsonConstructor]
        private SeasonStatAttributes(GameModeStat<RankedGameModeStat> rankedGameModeStats, GameModeStat<NormalGameModeStat> gameModeStats)
        {
            RankedGameModeStats = rankedGameModeStats;
            GameModeStats = gameModeStats;
        }
    }
}
