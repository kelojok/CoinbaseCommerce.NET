using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models;

public record BaseResponse<T>(
    [property: JsonPropertyName("data")]
    T? Data,

    [property: JsonPropertyName("metadata")]
    MetaData Metadata,

    [property: JsonPropertyName("pagination")]
    Pagination? Pagination);