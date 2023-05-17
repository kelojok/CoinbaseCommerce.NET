using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Charges;

public class CoinbaseCommerceChargeRequest
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("pricing_type")]
    public PricingType PricingType { get; set; }

    [JsonProperty("local_price")]
    public LocalPrice LocalPrice { get; set; }

    [JsonProperty("metadata")]
    public MetaData Metadata { get; set; }

    [JsonProperty("redirect_url")]
    public string RedirectUrl { get; set; }

    [JsonProperty("cancel_url")]
    public string CancelUrl { get; set; }

    [JsonProperty("requested_info")]
    public List<string> RequestedInfo { get; set; }
}
