using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class NormalGameModeStat
    {
        public long Assists { get; set; }
        public long Boosts { get; set; }
        public long DBnOs { get; set; }
        public long DailyKills { get; set; }
        public long DamageDealt { get; set; }
        public long Days { get; set; }
        public long DailyWins { get; set; }
        public long HeadshotKills { get; set; }
        public long Heals { get; set; }
        public long KillPoints { get; set; }
        public long Kills { get; set; }
        public long LongestKill { get; set; }
        public long LongestTimeSurvived { get; set; }
        public long Losses { get; set; }
        public long MaxKillStreaks { get; set; }
        public long MostSurvivalTime { get; set; }
        public long RankPoints { get; set; }
        public string RankPointsTitle { get; set; }
        public long Revives { get; set; }
        public long RideDistance { get; set; }
        public long RoadKills { get; set; }
        public long RoundMostKills { get; set; }
        public long RoundsPlayed { get; set; }
        public long Suicides { get; set; }
        public long SwimDistance { get; set; }
        public long TeamKills { get; set; }
        public long TimeSurvived { get; set; }
        public long Top10S { get; set; }
        public long VehicleDestroys { get; set; }
        public long WalkDistance { get; set; }
        public long WeaponsAcquired { get; set; }
        public long WeeklyKills { get; set; }
        public long WeeklyWins { get; set; }
        public long WinPoints { get; set; }
        public long Wins { get; set; }

        [JsonConstructor]
        private NormalGameModeStat(long assists, long boosts, long dBnOs, long dailyKills, long damageDealt, long days, long dailyWins, long headshotKills, long heals, long killPoints, long kills, long longestKill, long longestTimeSurvived, long losses, long maxKillStreaks, long mostSurvivalTime, long rankPoints, string rankPointsTitle, long revives, long rideDistance, long roadKills, long roundMostKills, long roundsPlayed, long suicides, long swimDistance, long teamKills, long timeSurvived, long top10S, long vehicleDestroys, long walkDistance, long weaponsAcquired, long weeklyKills, long weeklyWins, long winPoints, long wins)
        {
            Assists = assists;
            Boosts = boosts;
            DBnOs = dBnOs;
            DailyKills = dailyKills;
            DamageDealt = damageDealt;
            Days = days;
            DailyWins = dailyWins;
            HeadshotKills = headshotKills;
            Heals = heals;
            KillPoints = killPoints;
            Kills = kills;
            LongestKill = longestKill;
            LongestTimeSurvived = longestTimeSurvived;
            Losses = losses;
            MaxKillStreaks = maxKillStreaks;
            MostSurvivalTime = mostSurvivalTime;
            RankPoints = rankPoints;
            RankPointsTitle = rankPointsTitle;
            Revives = revives;
            RideDistance = rideDistance;
            RoadKills = roadKills;
            RoundMostKills = roundMostKills;
            RoundsPlayed = roundsPlayed;
            Suicides = suicides;
            SwimDistance = swimDistance;
            TeamKills = teamKills;
            TimeSurvived = timeSurvived;
            Top10S = top10S;
            VehicleDestroys = vehicleDestroys;
            WalkDistance = walkDistance;
            WeaponsAcquired = weaponsAcquired;
            WeeklyKills = weeklyKills;
            WeeklyWins = weeklyWins;
            WinPoints = winPoints;
            Wins = wins;
        }
    }
}
