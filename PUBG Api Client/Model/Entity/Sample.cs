using Newtonsoft.Json;
using PUBG.ApiClient.Caching;

namespace PUBG.ApiClient.Model.Entity
{
    [MaxRequestAge(0)]
    public class Sample
    {
        public string Type { get; private set; }
        public string Id { get; private set; }
        public SampleAttributes Attributes { get; private set; }
        public SampleRelationships Relationships { get; private set; }
        public ApiLink Links { get; private set; }

        [JsonConstructor]
        private Sample(string type, string id, SampleAttributes attributes, SampleRelationships relationships, ApiLink links)
        {
            Type = type;
            Id = id;
            Attributes = attributes;
            Relationships = relationships;
            Links = links;
        }
    }
}
