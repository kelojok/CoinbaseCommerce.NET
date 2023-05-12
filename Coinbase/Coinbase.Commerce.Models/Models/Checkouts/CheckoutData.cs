using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models.Checkouts
{
    public record CheckoutData(
        [property: JsonPropertyName("description")] string Description,

        [property: JsonPropertyName("id")] string Id,

        [property: JsonPropertyName("local_price")] LocalPrice LocalPrice,

        [property: JsonPropertyName("name")] string Name,

        [property: JsonPropertyName("organization_name")] string OrganizationName,

        [property: JsonPropertyName("pricing_type")] string PricingType,

        [property: JsonPropertyName("requested_info")] IReadOnlyList<string> RequestedInfo,

        [property: JsonPropertyName("resource")] string Resource
    ) : BrandData;

}
