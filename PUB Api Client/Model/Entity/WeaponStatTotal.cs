using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class WeaponStatTotal
    {
        public int MostDefeatsInAGame { get; private set; }
        public int Defeats { get; private set; }
        public float MostDamagePlayerInAGame { get; private set; }
        public float DamagePlayer { get; private set; }
        public int MostHeadShotsInAGame { get; private set; }
        public int HeadShots { get; private set; }
        public float LongestDefeat { get; private set; }
        public int LongRangeDefeats { get; private set; }
        public int Kills { get; private set; }
        public int MostKillsInAGame { get; private set; }
        public int Groggies { get; private set; }
        public int MostGroggiesInAGame { get; private set; }


        [JsonConstructor]
        private WeaponStatTotal(int MostDefeatsInAGame, int Defeats, float MostDamagePlayerInAGame, float DamagePlayer, int MostHeadShotsInAGame, int HeadShots, float LongestDefeat, int LongRangeDefeats, int Kills, int MostKillsInAGame, int Groggies, int MostGroggiesInAGame)
        {
            this.MostDefeatsInAGame = MostDefeatsInAGame;
            this.Defeats = Defeats;
            this.MostDamagePlayerInAGame = MostDamagePlayerInAGame;
            this.DamagePlayer = DamagePlayer;
            this.MostHeadShotsInAGame = MostHeadShotsInAGame;
            this.HeadShots = HeadShots;
            this.LongestDefeat = LongestDefeat;
            this.LongRangeDefeats = LongRangeDefeats;
            this.Kills = Kills;
            this.MostKillsInAGame = MostKillsInAGame;
            this.Groggies = Groggies;
            this.MostGroggiesInAGame = MostGroggiesInAGame;
        }
    }
}
