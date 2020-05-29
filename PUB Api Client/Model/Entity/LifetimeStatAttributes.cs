using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class LifetimeStatAttributes
    {
        public GameModeStat<NormalGameModeStat> GameModeStats { get; private set; }


        [JsonConstructor]
        private LifetimeStatAttributes(GameModeStat<NormalGameModeStat> gameModeStats)
        {
            GameModeStats = gameModeStats;
        }
    }
}
