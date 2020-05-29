using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class WeaponMasteryAttributes
    {
        public string Platform { get; private set; }
        public string SeasonId { get; private set; }
        public string LatestMatchId { get; private set; }
        public Dictionary<string,WeaponStat> WeaponSummaries { get; private set; }

        [JsonConstructor]
        public WeaponMasteryAttributes(string platform, string seasonId, Dictionary<string, WeaponStat> weaponSummaries, string latestMatchId)
        {
            Platform = platform;
            SeasonId = seasonId;
            WeaponSummaries = weaponSummaries;
            LatestMatchId = latestMatchId;
        }
    }
}
