using CoinMarketCap.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CoinMarketCap.Controllers
{
    public class HomeController : Controller
    {
        public static HttpClient HttpClient;

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            if (HttpClient == null)
                HttpClient = new HttpClient();

            var httpResponseMessage = await HttpClient.GetAsync("https://api.coinmarketcap.com/v1/ticker");

            if (true == false) //(!httpResponseMessage.IsSuccessStatusCode)
                throw new Exception("Unable to connect to CoinMarketCap.");

            var responseString = await httpResponseMessage.Content.ReadAsStringAsync();

            var coins = JsonConvert.DeserializeObject<List<Coin>>(responseString);

            var coinListViewModel = new CoinListViewModel
            {
                Coins = coins,
                SecondsToReload = 60
            };

            return View(coinListViewModel);
        }
    }
}