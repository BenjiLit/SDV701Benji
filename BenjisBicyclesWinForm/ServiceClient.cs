using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BenjisBicyclesWinForm
{
    public static class ServiceClient
    {
        internal async static Task<List<string>> GetBrandNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
            (await lcHttpClient.GetStringAsync("http://localhost:60060/api/bicycle/GetBrandNames/"));
        }

        internal async static Task<List<string>> GetOrdersAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
            (await lcHttpClient.GetStringAsync("http://localhost:60060/api/bicycle/GetOrders/"));
        }

        internal async static Task<List<decimal>> GetTotalOrderValueAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<decimal>>
            (await lcHttpClient.GetStringAsync("http://localhost:60060/api/bicycle/GetTotalOrderValue/"));
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

        internal async static Task<clsOrder> GetOrderAsync(string prOrder)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsOrder>
            (await lcHttpClient.GetStringAsync
        ("http://localhost:60060/api/bicycle/GetOrder?Order=" + prOrder));
        }

        internal async static Task<string> DeleteOrderAsync(clsOrder prOrder)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
            ($"http://localhost:60060/api/bicycle/DeleteOrder?CustomerName={prOrder.CustomerName}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal async static Task<string> DeleteBicycleAsync(clsBicycle prBicycle)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
            ($"http://localhost:60060/api/bicycle/DeleteBicycle?ModelName={prBicycle.ModelName}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }
    }
}
