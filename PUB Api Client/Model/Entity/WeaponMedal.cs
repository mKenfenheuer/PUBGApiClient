using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class WeaponMedal
    {
        public string MedalId { get; private set; }
        public int Count { get; private set; }

        [JsonConstructor]
        public WeaponMedal(string MedalId, int Count)
        {
            this.MedalId = MedalId;
            this.Count = Count;
        }
    }
}
