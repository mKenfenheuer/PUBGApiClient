using System;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.ApiClient.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = Run();
            task.Wait();
        }

        private static async Task Run()
        {
            PUBGApiClient pubgApiClient = new PUBGApiClient(ApiConstants.AuthToken);

            var weaponMastery = await pubgApiClient.GetWeaponMastery("steam", "account.52155c4edbbc4614bf4b3bf4ee9afcd3");
        }
    }
}
