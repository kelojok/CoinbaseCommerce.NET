using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Checkouts;

public class CoinbaseCommerceCheckoutRequest
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("requested_info")]
    public IReadOnlyList<string>? RequestedInfo { get; set; }

    [JsonProperty("pricing_type")]
    public PricingType PricingType { get; set; }

    [JsonProperty("local_price")]
    public LocalPrice LocalPrice { get; set; }
}