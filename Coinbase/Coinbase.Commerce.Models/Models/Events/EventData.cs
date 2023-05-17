using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Events
{
    public record EventData<T>(
        [property: JsonProperty("data")] T? Data,

        [property: JsonProperty("api_version")] string ApiVersion,

        [property: JsonProperty("created_at")] DateTime CreatedAt,

        [property: JsonProperty("id")] string Id,

        [property: JsonProperty("resource")] string Resource,

        [property: JsonProperty("type")] string Type
        )
    {
    }
}
