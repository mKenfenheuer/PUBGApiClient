using PUBG.ApiClient.Caching;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    [MaxRequestAge(60 * 15)]
    public class WeaponMastery
    {
        public string Type { get; private set; }
        public string AccountId { get; private set; }
        public WeaponMasteryAttributes Attributes { get; private set; }

        [JsonConstructor]
        public WeaponMastery(string type, string id, WeaponMasteryAttributes attributes)
        {
            Type = type;
            AccountId = id;
            Attributes = attributes;
        }
    }
}
