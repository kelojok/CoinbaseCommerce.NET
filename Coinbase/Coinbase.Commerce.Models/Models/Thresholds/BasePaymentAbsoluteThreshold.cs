using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Thresholds;

public record BasePaymentAbsoluteThreshold(
    [property: JsonProperty("amount")] [property: JsonPropertyName("amount")]
    string Amount,
    [property: JsonProperty("currency")] [property: JsonPropertyName("currency")]
    string Currency
);