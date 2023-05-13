using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models.Rates;

public record BaseExchangeRates(
    [property: JsonPropertyName("ETH-USD")] string ETHUSD,

    [property: JsonPropertyName("BTC-USD")] string BTCUSD,

    [property: JsonPropertyName("LTC-USD")] string LTCUSD,

    [property: JsonPropertyName("DOGE-USD")] string DOGEUSD,

    [property: JsonPropertyName("BCH-USD")] string BCHUSD,

    [property: JsonPropertyName("USDC-USD")] string USDCUSD,

    [property: JsonPropertyName("DAI-USD")] string DAIUSD,

    [property: JsonPropertyName("APE-USD")] string APEUSD,

    [property: JsonPropertyName("SHIB-USD")] string SHIBUSD,

    [property: JsonPropertyName("USDT-USD")] string USDTUSD,

    [property: JsonPropertyName("PMATIC-USD")] string PMATICUSD,

    [property: JsonPropertyName("PUSDC-USD")] string PUSDCUSD,

    [property: JsonPropertyName("PWETH-USD")] string PWETHUSD
);