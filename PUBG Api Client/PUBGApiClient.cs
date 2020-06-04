using System;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using PUBG.ApiClient.Model.Response;
using PUBG.ApiClient.Model.Entity;
using PUBG.ApiClient.Caching;
using System.Reflection;

namespace PUBG.ApiClient
{
    /// <summary>
    /// The api client used to access resources from the pubg api.
    /// </summary>
    public class PUBGApiClient
    {
        #region parameters
        private string AuthToken { get; set; }
        private IRequestCache RequestCache { get; set; }
        private static string BaseUrl => "https://api.pubg.com";
        #endregion

        #region constructors
        /// <summary>
        /// Constructor of the api client.
        /// </summary>
        /// <param name="authToken">The jwt bearer token used to authorize protected requests</param>
        /// <param name="requestCache">The request caching method used to cache requests. If null, InMemoryRequestCache is used.</param>
        public PUBGApiClient(string authToken, IRequestCache requestCache = null)
        {
            AuthToken = authToken;
            RequestCache = requestCache;

            //Use InMemoryRequestCache if not supplied
            if (RequestCache == null)
                RequestCache = new InMemoryRequestCache();
        }
        #endregion

        #region apicalls
        /// <summary>
        /// Gets players filtered by name
        /// </summary>
        /// <param name="shard">The game platform shard</param>
        /// <param name="playerNames">The player names, comma separated</param>
        /// <returns></returns>
        public Task<ApiResponse<Player[]>> GetPlayersByName(string shard, string playerNames)
        => MakeGETRequest<ApiResponse<Player[]>>($"/shards/{shard}/players?filter[playerName]={playerNames}");
        /// <summary>
        /// Gets players filtered by player id
        /// </summary>
        /// <param name="shard">The game platform shard</param>
        /// <param name="playerIds">The player ids, comma separated</param>
        /// <returns></returns>
        public Task<ApiResponse<Player[]>> GetPlayersById(string shard, string playerIds)
        => MakeGETRequest<ApiResponse<Player[]>>($"/shards/{shard}/players?filter[playerIds]={playerIds}");
        /// <summary>
        /// Gets a player by account id.
        /// </summary>
        /// <param name="shard">The game platform shard</param>
        /// <param name="accountId">The players account id</param>
        /// <returns></returns>
        public Task<ApiResponse<Player>> GetPlayerById(string shard, string accountId)
        => MakeGETRequest<ApiResponse<Player>>($"/shards/{shard}/players/{accountId}");
        /// <summary>
        /// Gets all available seasons
        /// </summary>
        /// <param name="shard">The game platform shard</param>
        /// <returns></returns>
        public Task<ApiResponse<Season[]>> GetSeasons(string shard)
        => MakeGETRequest<ApiResponse<Season[]>>($"/shards/{shard}/seasons");
        /// <summary>
        /// Gets the players stats for the selected season
        /// </summary>
        /// <param name="shard">The game platform shard</param>
        /// <param name="accountid">The players account id</param>
        /// <param name="seasonid">The season id</param>
        /// <returns></returns>
        public Task<ApiResponse<SeasonStat>> GetSeasonStats(string shard, string accountid, string seasonid)
        => MakeGETRequest<ApiResponse<SeasonStat>>($"/shards/{shard}/players/{accountid}/seasons/{seasonid}");
        /// <summary>
        /// Get season stats for up to 10 players.
        /// </summary>
        /// <param name="shard">The game platform shard</param>
        /// <param name="seasonid">The season id</param>
        /// <param name="gameMode">The game mode (solo, duo, etc.)</param>
        /// <param name="playerIds">The player account ids, comma separated</param>
        /// <param name="gamepad">Filters for gamepad stats for stadia players.</param>
        /// <returns></returns>
        public Task<ApiResponse<SeasonStat[]>> GetSeasonStats(string shard, string seasonid, string gameMode, string playerIds, bool gamepad = true)
        => MakeGETRequest<ApiResponse<SeasonStat[]>>($"/shards/{shard}/seasons/{seasonid}/gameMode/{gameMode}/players?filter[playerIds]={playerIds}&filter[gamepad]={gamepad.ToString().ToLower()}");
        /// <summary>
        /// Gets the players ranked stats for the selected season
        /// </summary>
        /// <param name="shard">The game platform shard</param>
        /// <param name="accountid">The players account id</param>
        /// <param name="seasonid">The season id</param>
        /// <returns></returns>
        public Task<ApiResponse<SeasonStat>> GetRankedSeasonStats(string shard, string accountid, string seasonid)
        => MakeGETRequest<ApiResponse<SeasonStat>>($"/shards/{shard}/players/{accountid}/seasons/{seasonid}/ranked");
        /// <summary>
        /// Gets the players lifetime stats
        /// </summary>
        /// <param name="shard">The game platform shard</param>
        /// <param name="accountid">The players account id</param>
        /// <returns></returns>
        public Task<ApiResponse<SeasonStat>> GetLifetimeStats(string shard, string accountid)
        => MakeGETRequest<ApiResponse<SeasonStat>>($"/shards/{shard}/players/{accountid}/seasons/lifetime");
        /// <summary>
        /// Get lifetime stats for up to 10 players.
        /// </summary>
        /// <param name="shard">The game platform shard</param>
        /// <param name="gameMode">The game mode (solo, duo, etc.)</param>
        /// <param name="playerIds">The player account ids, comma separated</param>
        /// <param name="gamepad">Filters for gamepad stats for stadia players.</param>
        /// <returns></returns>
        public Task<ApiResponse<SeasonStat[]>> GetLifetimeStats(string shard, string gameMode, string playerIds, bool gamepad = true)
        => MakeGETRequest<ApiResponse<SeasonStat[]>>($"/shards/{shard}/seasons/lifetime/gameMode/{gameMode}/players?filter[playerIds]={playerIds}&filter[gamepad]={gamepad.ToString().ToLower()}");
        /// <summary>
        /// Get weapon mastery information for a single player.
        /// </summary>
        /// <param name="shard">The game platform shard</param>
        /// <param name="accountId">The player account ids, comma separated</param>
        /// <returns></returns>
        public Task<ApiResponse<WeaponMastery>> GetWeaponMastery(string shard, string accountId)
        => MakeGETRequest<ApiResponse<WeaponMastery>>($"/shards/{shard}/players/{accountId}/weapon_mastery");
        /// <summary>
        /// Get match information
        /// </summary>
        /// <param name="shard">The game platform shard</param>
        /// <param name="matchId">The match id</param>
        /// <returns></returns>
        public Task<ApiResponse<Match>> GetMatch(string shard, string matchId)
        => MakeGETRequest<ApiResponse<Match>>($"/shards/{shard}/matches/{matchId}", false);
        /// <summary>
        /// Get match information
        /// </summary>
        /// <param name="shard">The game platform shard</param>
        /// <param name="matchId">The match id</param>
        /// <returns></returns>
        public Task<ApiResponse<Sample>> GetMatchSamples(string shard)
        => MakeGETRequest<ApiResponse<Sample>>($"/shards/{shard}/samples");
        #endregion

        #region httphandlers
        private async Task<T> MakeGETRequest<T>(string url, bool auth = true)
        {
            url = BaseUrl + url;
            HttpWebRequest req = HttpWebRequest.CreateHttp(url);
            req.Method = "GET";

            if(auth)
                req.Headers.Add("Authorization", "Bearer " + AuthToken);

            req.Headers.Add("Accept", "application/vnd.api+json");

            long MaxRequestAgeInSeconds = 0;

            Type type = typeof(T);
            if(type.GetGenericTypeDefinition() == typeof(ApiResponse<object>).GetGenericTypeDefinition())
            {
                FieldInfo field = type.GetRuntimeFields().Where(f => f.Name.Contains("Data")).FirstOrDefault();
                if (field != null
                    && field.FieldType != null
                    && field.FieldType.CustomAttributes != null)
                {

                    MaxRequestAgeAttribute attr = (MaxRequestAgeAttribute) Attribute.GetCustomAttribute(field.FieldType, typeof(MaxRequestAgeAttribute));
                    MaxRequestAgeInSeconds = attr.MaxRequestAgeInSeconds;
                }
            }


            string responseStr = await RequestCache.TryGetResponseFromCache(url, TimeSpan.FromSeconds(MaxRequestAgeInSeconds));

            if (responseStr == null)
            {
                WebResponse httpWebResponse;

                try
                {
                    httpWebResponse = await req.GetResponseAsync();
                }
                catch (WebException ex)
                {
                    httpWebResponse = ex.Response;
                    Console.WriteLine(ex);
                }

                if (httpWebResponse == null)
                    return default(T);

                Stream responseStream = httpWebResponse.GetResponseStream();

                StreamReader reader = new StreamReader(responseStream);

                responseStr = reader.ReadToEnd();

                await RequestCache.AddResponseToCache(url, responseStr, DateTime.UtcNow);
            }

            T response = JsonConvert.DeserializeObject<T>(responseStr);

            return response;
        }
        #endregion
    }
}

