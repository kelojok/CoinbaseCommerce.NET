using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Charges;

public record CoinbaseCommerceChargeRequest(
    [property: JsonPropertyName("name")] string Name,

    [property: JsonPropertyName("description")] string Description,

    [property: JsonPropertyName("pricing_type")] PricingType PricingType,

    [property: JsonPropertyName("local_price")] LocalPrice LocalPrice,

    [property: JsonPropertyName("metadata")] MetaData Metadata,

    [property: JsonPropertyName("redirect_url")] string RedirectUrl,

    [property: JsonPropertyName("cancel_url")] string CancelUrl,

    [property: JsonPropertyName("requested_info")] List<string> RequestedInfo
);