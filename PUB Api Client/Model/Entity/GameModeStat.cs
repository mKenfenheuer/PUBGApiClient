using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class GameModeStat<T>
    {
        public T Duo { get; private set; }
        public T DuoFPP { get; private set; }
        public T Solo { get; private set; }
        public T SoloFPP { get; private set; }
        public T Squad { get; private set; }
        public T SquadFPP { get; private set; }
        public int BestRankPoint { get; private set; }

        [JsonConstructor]
        private GameModeStat(T duo, [JsonProperty("duo-fpp")] T duoFPP, T solo, [JsonProperty("solo-fpp")] T soloFPP, T squad, [JsonProperty("squad-fpp")]  T squadFPP, int bestRankPoint)
        {
            Duo = duo;
            DuoFPP = duoFPP;
            Solo = solo;
            SoloFPP = soloFPP;
            Squad = squad;
            SquadFPP = squadFPP;
            BestRankPoint = bestRankPoint;
        }
    }
}
