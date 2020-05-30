using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class ParticipantStats
    {        
        public long DBNOs { get; private set; }
        public long Assists { get; private set; }
        public long Boosts { get; private set; }
        public double DamageDealt { get; private set; }
        public string DeathType { get; private set; }
        public long HeadshotKills { get; private set; }
        public long Heals { get; private set; }
        public long KillPlace { get; private set; }
        public long KillStreaks { get; private set; }
        public long Kills { get; private set; }
        public double LongestKill { get; private set; }
        public string Name { get; private set; }
        public string PlayerId { get; private set; }
        public long Revives { get; private set; }
        public long RideDistance { get; private set; }
        public long RoadKills { get; private set; }
        public long SwimDistance { get; private set; }
        public long TeamKills { get; private set; }
        public double TimeSurvived { get; private set; }
        public long VehicleDestroys { get; private set; }
        public double WalkDistance { get; private set; }
        public long WeaponsAcquired { get; private set; }
        public long WinPlace { get; private set; }

        [JsonConstructor]
        private ParticipantStats([JsonProperty("DBNOs")] long dBNOs, long assists, long boosts, double damageDealt, string deathType, long headshotKills, long heals, long killPlace, long killStreaks, long kills, double longestKill, string name, string playerId, long revives, long rideDistance, long roadKills, long swimDistance, long teamKills, double timeSurvived, long vehicleDestroys, double walkDistance, long weaponsAcquired, long winPlace)
        {
            DBNOs = dBNOs;
            Assists = assists;
            Boosts = boosts;
            DamageDealt = damageDealt;
            DeathType = deathType;
            HeadshotKills = headshotKills;
            Heals = heals;
            KillPlace = killPlace;
            KillStreaks = killStreaks;
            Kills = kills;
            LongestKill = longestKill;
            Name = name;
            PlayerId = playerId;
            Revives = revives;
            RideDistance = rideDistance;
            RoadKills = roadKills;
            SwimDistance = swimDistance;
            TeamKills = teamKills;
            TimeSurvived = timeSurvived;
            VehicleDestroys = vehicleDestroys;
            WalkDistance = walkDistance;
            WeaponsAcquired = weaponsAcquired;
            WinPlace = winPlace;
        }
    }
}
