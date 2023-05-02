using System.Text.Json.Serialization;
using Coinbase.Commerce.Models.Models.Converters;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public record BaseResponse(
    [property: JsonProperty("data")]
    [property: JsonPropertyName("data")]
    [Newtonsoft.Json.JsonConverter(typeof(DataListConverter))]
    List<Data>? Data,
    [property: JsonProperty("metadata")] [property: JsonPropertyName("metadata")]
    MetaData Metadata,
    [property: JsonProperty("pagination")] [property: JsonPropertyName("pagination")]
    Pagination? Pagination);