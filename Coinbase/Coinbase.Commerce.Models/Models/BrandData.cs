using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models;

public record BrandData(
    [property: JsonPropertyName("brand_color")]
    string BrandColor,

    [property: JsonPropertyName("brand_logo_url")]
    string BrandLogoUrl,

    [property: JsonPropertyName("coinbase_managed_merchant")]
    bool? CoinbaseManagedMerchant
)
{
    public BrandData() : this("", "", null) { }
};