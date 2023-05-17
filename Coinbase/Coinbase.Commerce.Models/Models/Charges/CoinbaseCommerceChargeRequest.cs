using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Charges;

public record CoinbaseCommerceChargeRequest(
    [property: JsonProperty("name")] string Name,

    [property: JsonProperty("description")] string Description,

    [property: JsonProperty("pricing_type")] PricingType PricingType,

    [property: JsonProperty("local_price")] LocalPrice LocalPrice,

    [property: JsonProperty("metadata")] MetaData Metadata,

    [property: JsonProperty("redirect_url")] string RedirectUrl,

    [property: JsonProperty("cancel_url")] string CancelUrl,

    [property: JsonProperty("requested_info")] List<string> RequestedInfo
);