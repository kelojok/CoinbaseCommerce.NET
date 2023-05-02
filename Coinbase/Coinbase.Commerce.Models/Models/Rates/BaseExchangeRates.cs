using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Rates;

public record BaseExchangeRates(
    [property: JsonProperty("ETH-USD")] [property: JsonPropertyName("ETH-USD")]
    string ETHUSD,
    [property: JsonProperty("BTC-USD")] [property: JsonPropertyName("BTC-USD")]
    string BTCUSD,
    [property: JsonProperty("LTC-USD")] [property: JsonPropertyName("LTC-USD")]
    string LTCUSD,
    [property: JsonProperty("DOGE-USD")] [property: JsonPropertyName("DOGE-USD")]
    string DOGEUSD,
    [property: JsonProperty("BCH-USD")] [property: JsonPropertyName("BCH-USD")]
    string BCHUSD,
    [property: JsonProperty("USDC-USD")] [property: JsonPropertyName("USDC-USD")]
    string USDCUSD,
    [property: JsonProperty("DAI-USD")] [property: JsonPropertyName("DAI-USD")]
    string DAIUSD,
    [property: JsonProperty("APE-USD")] [property: JsonPropertyName("APE-USD")]
    string APEUSD,
    [property: JsonProperty("SHIB-USD")] [property: JsonPropertyName("SHIB-USD")]
    string SHIBUSD,
    [property: JsonProperty("USDT-USD")] [property: JsonPropertyName("USDT-USD")]
    string USDTUSD,
    [property: JsonProperty("PMATIC-USD")] [property: JsonPropertyName("PMATIC-USD")]
    string PMATICUSD,
    [property: JsonProperty("PUSDC-USD")] [property: JsonPropertyName("PUSDC-USD")]
    string PUSDCUSD,
    [property: JsonProperty("PWETH-USD")] [property: JsonPropertyName("PWETH-USD")]
    string PWETHUSD
);