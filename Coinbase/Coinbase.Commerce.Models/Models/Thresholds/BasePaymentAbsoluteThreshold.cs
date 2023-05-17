using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Thresholds;

public record BasePaymentAbsoluteThreshold(
    [property: JsonProperty("amount")] string Amount,

    [property: JsonProperty("currency")] string Currency
);