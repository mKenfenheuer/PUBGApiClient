using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class ApiLink
    {
        public string Schema { get; private set; }
        public string Self { get; private set; }

        [JsonConstructor]
        private ApiLink(string schema, string self)
        {
            Schema = schema;
            Self = self;
        }
    }
}
