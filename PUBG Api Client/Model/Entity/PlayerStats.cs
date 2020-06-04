using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class PlayerStats
    {
        public long RankPoints { get; private set; }
        public long Wins { get; private set; }
        public long Games { get; private set; }
        public double WinRatio { get; private set; }
        public long AverageDamage { get; private set; }
        public long Kills { get; private set; }
        public double KillDeathRatio { get; private set; }
        public long Kda { get; private set; }
        public double AverageRank { get; private set; }
        public string Tier { get; private set; }
        public string SubTier { get; private set; }

        [JsonConstructor]
        private PlayerStats(long rankPoints, long wins, long games, double winRatio, long averageDamage, long kills, double killDeathRatio, long kda, double averageRank, string tier, string subTier)
        {
            RankPoints = rankPoints;
            Wins = wins;
            Games = games;
            WinRatio = winRatio;
            AverageDamage = averageDamage;
            Kills = kills;
            KillDeathRatio = killDeathRatio;
            Kda = kda;
            AverageRank = averageRank;
            Tier = tier;
            SubTier = subTier;
        }
    }
}
