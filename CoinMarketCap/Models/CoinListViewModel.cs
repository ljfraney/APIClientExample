using System.Collections.Generic;

namespace CoinMarketCap.Models
{
    public class CoinListViewModel
    {
        public List<Coin> Coins { get; set; }

        public int SecondsToReload { get; set; }
    }
}