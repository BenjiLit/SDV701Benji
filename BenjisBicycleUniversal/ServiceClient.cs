using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BenjisBicycleUniversal
{
    public static class ServiceClient
    {
        internal async static Task<List<string>> GetBrandNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
            (await lcHttpClient.GetStringAsync("http://localhost:60060/api/bicycle/GetBrandNames/"));
        }           
               
        internal async static Task<clsBrand> GetBrandAsync(string prBrandName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsBrand>
            (await lcHttpClient.GetStringAsync("http://localhost:60060/api/bicycle/GetBrandName?BrandName=" + prBrandName));
        }

        internal async static Task<List<string>> GetBrandsBicycleAsync(string prBrandName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
            (await lcHttpClient.GetStringAsync("http://localhost:60060/api/bicycle/GetBrandsBicycle?BrandName=" + prBrandName));
        }

    }
}
