using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Checkouts;

public record CoinbaseCommerceCheckoutRequest(
    [property: JsonProperty("name")] string Name,

    [property: JsonProperty("description")] string Description,

    [property: JsonProperty("requested_info")] IReadOnlyList<string>? RequestedInfo,

    [property: JsonProperty("pricing_type")] PricingType PricingType,

    [property: JsonProperty("local_price")] LocalPrice LocalPrice
);