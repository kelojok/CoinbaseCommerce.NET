using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models.Thresholds;

public record BasePaymentAbsoluteThreshold(
    [property: JsonPropertyName("amount")] string Amount,

    [property: JsonPropertyName("currency")] string Currency
);