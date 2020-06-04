using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class ApiData<T>
    {
        public T Data { get; private set; }

        [JsonConstructor]
        private ApiData(T data)
        {
            Data = data;
        }
    }
}
