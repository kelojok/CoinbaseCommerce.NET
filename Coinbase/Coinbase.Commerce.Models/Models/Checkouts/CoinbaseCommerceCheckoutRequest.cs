using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Checkouts;

public record CoinbaseCommerceCheckoutRequest(
    [property: JsonPropertyName("name")] string Name,

    [property: JsonPropertyName("description")] string Description,

    [property: JsonPropertyName("requested_info")] IReadOnlyList<string>? RequestedInfo,

    [property: JsonPropertyName("pricing_type")] string PricingType,

    [property: JsonPropertyName("local_price")] LocalPrice LocalPrice
);