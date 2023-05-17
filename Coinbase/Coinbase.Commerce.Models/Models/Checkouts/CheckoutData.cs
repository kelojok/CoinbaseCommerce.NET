using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Checkouts
{
    public record CheckoutData(
        [property: JsonProperty("description")] string Description,

        [property: JsonProperty("id")] string Id,

        [property: JsonProperty("local_price")] LocalPrice LocalPrice,

        [property: JsonProperty("name")] string Name,

        [property: JsonProperty("organization_name")] string OrganizationName,

        [property: JsonProperty("pricing_type")] PricingType PricingType,

        [property: JsonProperty("requested_info")] IReadOnlyList<string> RequestedInfo,

        [property: JsonProperty("resource")] string Resource
    ) : BrandData;

}
