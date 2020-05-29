using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class ApiError
    {
        public string Title { get; private set; }

        [JsonConstructor]
        private ApiError(string title)
        {
            Title = title;
        }
    }
}
