# PUBGApiClient
A .NET Standard API Client for the PUBG Statistics API

## How to use it?

 1. Reference the project or a precompiled assembly in your own project. A NuGet Package will be available once the library is stable.
 2. Include the nescessary namespaces:
 
        using PUBG.ApiClient;
        using PUBG.ApiClient.Model.Response;
        using PUBG.ApiClient.Model.Entity;

 3. Create a new instance of the `PUBGApiClient` like below (you will have to supply your own auth token):
 
        PUBGApiClient pubgApiClient = new PUBGApiClient(ApiConstants.AuthToken);

4. Make requests to the api using the api client:

       var rankedPlayerStats = await pubgApiClient.GetRankedSeasonStats("steam", account.c0e530e9b7244b358def282782f893af", "division.bro.official.pc-2018-07");

## The usage guide mentioned caching? What about caching? Do i have to implement this on my own?
No. The Api client handles this for you. You can supply an `IRequestCache` to the constructor of the `PUBGApiClient` like below:

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

## Issues or ideas? Feel free to create an issue, fork and pull requests!
