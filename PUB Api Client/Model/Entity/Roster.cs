using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    [MaxRequestAge(int.MaxValue)]
    public class Roster
    {
        public string Type { get; private set; }
        public string Id { get; private set; }
        public RosterAttributes Attributes { get; private set; }
        public RosterRelationships Relationships { get; private set; }
        public ApiLink Links { get; private set; }

        [JsonConstructor]
        private Roster(string type, string id, RosterAttributes attributes, RosterRelationships relationships, ApiLink links)
        {
            Type = type;
            Id = id;
            Attributes = attributes;
            Relationships = relationships;
            Links = links;
        }
    }
}
