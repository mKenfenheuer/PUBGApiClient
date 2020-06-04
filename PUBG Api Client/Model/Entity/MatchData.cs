using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class MatchData
    {
        public Match[] Data { get; private set; }

        [JsonConstructor]
        private MatchData(Match[] data)
        {
            Data = data;
        }
    }
}
