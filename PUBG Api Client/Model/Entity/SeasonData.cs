using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class SeasonData
    {
        public Season Data { get; private set; }

        [JsonConstructor]
        private SeasonData(Season data)
        {
            Data = data;
        }
    }
}
