using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Rates;

public record BaseExchangeRates(
    [property: JsonProperty("ETH-USD")] string ETHUSD,

    [property: JsonProperty("BTC-USD")] string BTCUSD,

    [property: JsonProperty("LTC-USD")] string LTCUSD,

    [property: JsonProperty("DOGE-USD")] string DOGEUSD,

    [property: JsonProperty("BCH-USD")] string BCHUSD,

    [property: JsonProperty("USDC-USD")] string USDCUSD,

    [property: JsonProperty("DAI-USD")] string DAIUSD,

    [property: JsonProperty("APE-USD")] string APEUSD,

    [property: JsonProperty("SHIB-USD")] string SHIBUSD,

    [property: JsonProperty("USDT-USD")] string USDTUSD,

    [property: JsonProperty("PMATIC-USD")] string PMATICUSD,

    [property: JsonProperty("PUSDC-USD")] string PUSDCUSD,

    [property: JsonProperty("PWETH-USD")] string PWETHUSD
);