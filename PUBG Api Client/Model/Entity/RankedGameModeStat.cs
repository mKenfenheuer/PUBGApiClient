using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class RankedGameModeStat
    {
        public long CurrentRankPoint { get; private set; }
        public long BestRankPoint { get; private set; }
        public StatTier CurrentTier { get; private set; }
        public StatTier BestTier { get; private set; }
        public long RoundsPlayed { get; private set; }
        public long AvgRank { get; private set; }
        public long AvgSurvivalTime { get; private set; }
        public long Top10Ratio { get; private set; }
        public long WinRatio { get; private set; }
        public long Assists { get; private set; }
        public long Wins { get; private set; }
        public long Kda { get; private set; }
        public long Kdr { get; private set; }
        public long Kills { get; private set; }
        public long Deaths { get; private set; }
        public long RoundMostKills { get; private set; }
        public long LongestKill { get; private set; }
        public long HeadshotKills { get; private set; }
        public long HeadshotKillRatio { get; private set; }
        public long DamageDealt { get; private set; }
        public long DBnOs { get; private set; }
        public long ReviveRatio { get; private set; }
        public long Revives { get; private set; }
        public long Heals { get; private set; }
        public long Boosts { get; private set; }
        public long WeaponsAcquired { get; private set; }
        public long TeamKills { get; private set; }
        public long PlayTime { get; private set; }
        public long KillStreak { get; private set; }

        [JsonConstructor]
        private RankedGameModeStat(long currentRankPoint, long bestRankPoint, StatTier currentTier, StatTier bestTier, long roundsPlayed, long avgRank, long avgSurvivalTime, long top10Ratio, long winRatio, long assists, long wins, long kda, long kdr, long kills, long deaths, long roundMostKills, long longestKill, long headshotKills, long headshotKillRatio, long damageDealt, long dBnOs, long reviveRatio, long revives, long heals, long boosts, long weaponsAcquired, long teamKills, long playTime, long killStreak)
        {
            CurrentRankPoint = currentRankPoint;
            BestRankPoint = bestRankPoint;
            CurrentTier = currentTier;
            BestTier = bestTier;
            RoundsPlayed = roundsPlayed;
            AvgRank = avgRank;
            AvgSurvivalTime = avgSurvivalTime;
            Top10Ratio = top10Ratio;
            WinRatio = winRatio;
            Assists = assists;
            Wins = wins;
            Kda = kda;
            Kdr = kdr;
            Kills = kills;
            Deaths = deaths;
            RoundMostKills = roundMostKills;
            LongestKill = longestKill;
            HeadshotKills = headshotKills;
            HeadshotKillRatio = headshotKillRatio;
            DamageDealt = damageDealt;
            DBnOs = dBnOs;
            ReviveRatio = reviveRatio;
            Revives = revives;
            Heals = heals;
            Boosts = boosts;
            WeaponsAcquired = weaponsAcquired;
            TeamKills = teamKills;
            PlayTime = playTime;
            KillStreak = killStreak;
        }
    }
}
