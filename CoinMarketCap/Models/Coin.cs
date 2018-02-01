using Newtonsoft.Json;
using System;

namespace CoinMarketCap.Models
{
    public class Coin
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }

        public int Rank { get; set; }

        [JsonProperty(PropertyName = "price_usd")]
        public string PriceUSD { get; set; }

        [JsonProperty(PropertyName = "price_btc")]
        public string PriceBTC { get; set; }

        [JsonProperty(PropertyName = "24h_volume_usd")]
        public string TwentyFourHourVolumeUSD { get; set; }

        [JsonProperty(PropertyName = "market_cap_usd")]
        public string MarketCapUSD { get; set; }

        [JsonProperty(PropertyName = "available_supply")]
        public string AvailableSupply { get; set; }

        [JsonProperty(PropertyName = "total_supply")]
        public string TotalSupply { get; set; }

        [JsonProperty(PropertyName = "max_supply")]
        public string MaxSupply { get; set; }

        [JsonProperty(PropertyName = "percent_change_1h")]
        public string PercentChange1Hour { get; set; }

        [JsonProperty(PropertyName = "percent_change_24h")]
        public string PercentChange24Hour { get; set; }

        [JsonProperty(PropertyName = "percent_change_7d")]
        public string PercentChange7Day { get; set; }

        [JsonProperty(PropertyName = "last_updated")]
        public int LastUpdatedEpoch { get; set; }

        public DateTime LastUpdated
        {
            get
            {
                DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                return epoch.AddSeconds(LastUpdatedEpoch).ToLocalTime();
            }
        }
    }
}