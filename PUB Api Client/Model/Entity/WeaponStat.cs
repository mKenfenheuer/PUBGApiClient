using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class WeaponStat
    {
        public int XPTotal { get; private set; }
        public int LevelCurrent { get; private set; }
        public int TierCurrent { get; private set; }
        public WeaponStatTotal StatsTotal { get; private set; }

        [JsonConstructor]
        public WeaponStat(int XPTotal, int LevelCurrent, int TierCurrent, WeaponStatTotal StatsTotal)
        {
            this.XPTotal = XPTotal;
            this.LevelCurrent = LevelCurrent;
            this.TierCurrent = TierCurrent;
            this.StatsTotal = StatsTotal;
        }
    }
}
