using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models;

public record LocalPrice(
    [property: JsonPropertyName("currency")] string Currency,

    [property: JsonPropertyName("amount")] string Amount
);