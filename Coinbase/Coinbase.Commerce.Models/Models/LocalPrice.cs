using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public record LocalPrice(
    [property: JsonProperty("currency")] [property: JsonPropertyName("currency")]
    string Currency,
    [property: JsonProperty("amount")] [property: JsonPropertyName("amount")]
    string Amount
);