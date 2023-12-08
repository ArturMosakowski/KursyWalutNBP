using KursyWalutNBP.Models;
using Newtonsoft.Json;

namespace KursyWalutNBP.Services
{
    public class ExchangeRateService
    {
        public async Task<ExchangeRateData> CallApi()
        {
            string apiBaseUrl = "https://api.nbp.pl/api/exchangerates/tables/a/";
            string format = "json";

            using (HttpClient client = new())
            {
                try
                {
                    var uriBuilder = new UriBuilder(apiBaseUrl)
                    {
                        Query = $"format={format}"
                    };

                    HttpResponseMessage response = await client.GetAsync(uriBuilder.Uri);
                    response.EnsureSuccessStatusCode();

                    string responsAsString = await response.Content.ReadAsStringAsync();

                    List<ExchangeRateData> result = JsonConvert.DeserializeObject<List<ExchangeRateData>>(responsAsString);

                    return result[0];
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"HTTP Request Exception: {ex.Message}");
                    throw;
                }
            }
        }
    }
}
