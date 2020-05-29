using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class NormalGameModeStat
    {
        public long Assists { get; private set; }
        public long Boosts { get; private set; }
        public long DBnOs { get; private set; }
        public long DailyKills { get; private set; }
        public long DamageDealt { get; private set; }
        public long Days { get; private set; }
        public long DailyWins { get; private set; }
        public long HeadshotKills { get; private set; }
        public long Heals { get; private set; }
        public long KillPoints { get; private set; }
        public long Kills { get; private set; }
        public long LongestKill { get; private set; }
        public long LongestTimeSurvived { get; private set; }
        public long Losses { get; private set; }
        public long MaxKillStreaks { get; private set; }
        public long MostSurvivalTime { get; private set; }
        public long RankPoints { get; private set; }
        public string RankPointsTitle { get; private set; }
        public long Revives { get; private set; }
        public long RideDistance { get; private set; }
        public long RoadKills { get; private set; }
        public long RoundMostKills { get; private set; }
        public long RoundsPlayed { get; private set; }
        public long Suicides { get; private set; }
        public long SwimDistance { get; private set; }
        public long TeamKills { get; private set; }
        public long TimeSurvived { get; private set; }
        public long Top10S { get; private set; }
        public long VehicleDestroys { get; private set; }
        public long WalkDistance { get; private set; }
        public long WeaponsAcquired { get; private set; }
        public long WeeklyKills { get; private set; }
        public long WeeklyWins { get; private set; }
        public long WinPoints { get; private set; }
        public long Wins { get; private set; }

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
