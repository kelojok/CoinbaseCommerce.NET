using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Checkouts;

public record CoinbaseCommerceCheckoutRequest(
    [property: JsonProperty("name")] [property: JsonPropertyName("name")]
    string Name,
    [property: JsonProperty("description")] [property: JsonPropertyName("description")]
    string Description,
    [property: JsonProperty("requested_info")] [property: JsonPropertyName("requested_info")]
    IReadOnlyList<string>? RequestedInfo,
    [property: JsonProperty("pricing_type")] [property: JsonPropertyName("pricing_type")]
    string PricingType,
    [property: JsonProperty("local_price")] [property: JsonPropertyName("local_price")]
    LocalPrice LocalPrice
);