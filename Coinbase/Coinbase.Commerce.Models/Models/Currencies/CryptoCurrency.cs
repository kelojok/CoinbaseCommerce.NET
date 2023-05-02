using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Currencies;

public record CryptoCurrency
(
    [property: JsonProperty("amount")] [property: JsonPropertyName("amount")]
    string Amount,
    [property: JsonProperty("currency")] [property: JsonPropertyName("currency")]
    string Currency
);