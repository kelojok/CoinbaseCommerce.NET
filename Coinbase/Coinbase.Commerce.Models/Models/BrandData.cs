using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public record BrandData(
    [property: JsonProperty("brand_color")] string BrandColor,

    [property: JsonProperty("brand_logo_url")] string BrandLogoUrl,

    [property: JsonProperty("coinbase_managed_merchant")] bool? CoinbaseManagedMerchant
)
{
    public BrandData() : this("", "", null) { }
};