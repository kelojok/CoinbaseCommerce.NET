using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models.Events
{
    public record EventData<T>(
        [property: JsonPropertyName("data")] T? Data,

        [property: JsonPropertyName("api_version")] string ApiVersion,

        [property: JsonPropertyName("created_at")] DateTime CreatedAt,

        [property: JsonPropertyName("id")] string Id,

        [property: JsonPropertyName("resource")] string Resource,

        [property: JsonPropertyName("type")] string Type
        )
    {
    }
}
