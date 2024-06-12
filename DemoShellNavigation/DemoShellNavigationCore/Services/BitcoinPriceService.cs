using DemoShellNavigation.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoShellNavigation.Services
{
    class BitcoinPriceService
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<BitcoinData> GetBitcoinPriceIndexAsync()
        {
            var response = await client.GetStringAsync("https://api.coindesk.com/v1/bpi/currentprice.json");
            return JsonConvert.DeserializeObject<BitcoinData>(response);
        }
    }
}
