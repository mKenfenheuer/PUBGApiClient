
# PUBGApiClient
A .NET Standard API Client for the PUBG Statistics API

### Current status: work in progress

| Endpoint | Status |
|--|--|
| [Players](https://documentation.pubg.com/en/players-endpoint.html) | fully implemented |
| [Season stats](https://documentation.pubg.com/en/seasons-endpoint.html) | fully implemented |
| [Lifetime stats](https://documentation.pubg.com/en/lifetime-stats.html) | fully implemented |
| [Weapon mastery](https://documentation.pubg.com/en/weapon-mastery-endpoint.html) | fully implemented |
| [Matches](https://documentation.pubg.com/en/matches-endpoint.html) | fully implemented |
| [Leaderboards](https://documentation.pubg.com/en/leaderboards-endpoint.html) | fully implemented |
| [Tournaments](https://documentation.pubg.com/en/tournaments-endpoint.html) | fully implemented |
| [Samples](https://documentation.pubg.com/en/samples-endpoint.html) | fully implemented |
| [Telemetry](https://documentation.pubg.com/en/telemetry.html) | not implemented yet |
| [Status](https://documentation.pubg.com/en/status-endpoint.html) | not implemented yet |

Caching: 
- Basic in-memory caching available

## How to use it?

 1. Acquire an API key for authorization from the [pubg api developer portal.](https://developer.pubg.com/apps?locale=en)
 2. Reference the project or a precompiled assembly in your own project. A NuGet Package will be available once the library is stable and implements all available endpoints.
 3. Include the nescessary namespaces:
 
        using PUBG.ApiClient;
        using PUBG.ApiClient.Model.Response;
        using PUBG.ApiClient.Model.Entity;

 4. Create a new instance of the `PUBGApiClient` like below (you will have to supply your own auth token):
 
        PUBGApiClient pubgApiClient = new PUBGApiClient(ApiConstants.AuthToken);

5. Make requests to the api using the api client:

       var rankedPlayerStats = await pubgApiClient.GetRankedSeasonStats("steam", account.c0e530e9b7244b358def282782f893af", "division.bro.official.pc-2018-07");

## The usage guide mentioned caching? What about caching? Do i have to implement this on my own?
No. The Api client handles this for you. By default `InMemoryRequestCache` is used. You can supply an `IRequestCache` to the constructor of the `PUBGApiClient` like below:

    //This is the default behaviour of new PUBGApiClient(ApiConstants.AuthToken). This is just for illustration purposes!
    InMemoryRequestCache inMemoryRequestCache = new InMemoryRequestCache();
    PUBGApiClient pubgApiClient = new PUBGApiClient(ApiConstants.AuthToken, inMemoryRequestCache);

You can also disable caching by providing a `NoRequestCache` to the constructor of the `PUBGApiClient` like below:

    NoRequestCache noRequestCache = new NoRequestCache();
    PUBGApiClient pubgApiClient = new PUBGApiClient(ApiConstants.AuthToken, noRequestCache);

Other request caches will get implemented in the future but in the meantime you can also create your own:

    using PUBG.ApiClient.Caching;
    public class CustomRequestCache : IRequestCache
    {
        public async Task AddResponseToCache(string requestUrl, string response, DateTime requestTime)
        {
            //Implement cache store logic here
        }

        public async Task<string> TryGetResponseFromCache(string requestUrl, TimeSpan maxAge)
        {
            //Implement cache retrieve logic here
        }
    }

By default there are the following caching times defined in code by the `[MaxRequestAge(60 * 15)]` attribute:

| Endpoint | Default cache time |
|--|--|
| Players | 15 mins |
| Season stats | 15 mins |
| Lifetime stats | 15 mins |
| Weapon mastery | 15 mins |
| Matches | Infinite |
| Leaderboards | 2 hours |
| Tournaments | 15 mins |
| Samples | No caching |
| Telemetry | Infinite |
| Status | No caching |  


## Issues or ideas? Feel free to create an issue, fork and pull requests!

## Known issues

For API related known issues please head over to the [known issues section of the api documentation](https://documentation.pubg.com/en/known-issues.html)

