using Newtonsoft.Json;
using PUBG.ApiClient.Model.Entity;

namespace PUBG.ApiClient.Model.Response
{
    public class ApiResponse<T>
    {
        public T Data { get; private set; }
        public ApiError[] Errors { get; private set; }
        public ApiLink Links { get; private set; }
        public dynamic[] Included { get; set; }

        [JsonConstructor]
        private ApiResponse(ApiError[] errors, ApiLink links, T data, dynamic[] included)
        {
            Data = data;
            Links = links;
            Errors = errors;
            Included = included;
        }
    }
}
