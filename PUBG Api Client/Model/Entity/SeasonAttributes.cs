using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class SeasonAttributes
    {
        public bool IsCurrentSeason { get; private set; }
        public bool IsOffseason { get; private set; }

        [JsonConstructor]
        private SeasonAttributes(bool isCurrentSeason, bool isOffseason)
        {
            IsCurrentSeason = isCurrentSeason;
            IsOffseason = isOffseason;
        }
    }
}
