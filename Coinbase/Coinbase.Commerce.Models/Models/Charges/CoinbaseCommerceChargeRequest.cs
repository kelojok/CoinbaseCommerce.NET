using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Charges;

public record CoinbaseCommerceChargeRequest(
    [property: JsonProperty("name")] [property: JsonPropertyName("name")]
    string Name,
    [property: JsonProperty("description")] [property: JsonPropertyName("description")]
    string Description,
    [property: JsonProperty("pricing_type")] [property: JsonPropertyName("pricing_type")]
    string PricingType,
    [property: JsonProperty("local_price")] [property: JsonPropertyName("local_price")]
    LocalPrice LocalPrice,
    [property: JsonProperty("metadata")] [property: JsonPropertyName("metadata")]
    MetaData Metadata,
    [property: JsonProperty("redirect_url")] [property: JsonPropertyName("redirect_url")]
    string RedirectUrl,
    [property: JsonProperty("cancel_url")] [property: JsonPropertyName("cancel_url")]
    string CancelUrl,
    [property: JsonProperty("requested_info")] [property: JsonPropertyName("requested_info")]
    List<string> RequestedInfo
);