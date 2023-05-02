using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public record Pagination(
    [property: JsonProperty("order")] [property: JsonPropertyName("order")]
    string Order,
    [property: JsonProperty("starting_after")] [property: JsonPropertyName("starting_after")]
    string StartingAfter,
    [property: JsonProperty("ending_before")] [property: JsonPropertyName("ending_before")]
    string EndingBefore,
    [property: JsonProperty("previous_uri")] [property: JsonPropertyName("previous_uri")]
    string PreviousUri,
    [property: JsonProperty("next_uri")] [property: JsonPropertyName("next_uri")]
    string NextUri,
    [property: JsonProperty("total")] [property: JsonPropertyName("total")]
    int? Total,
    [property: JsonProperty("yielded")] [property: JsonPropertyName("yielded")]
    int? Yielded,
    [property: JsonProperty("limit")] [property: JsonPropertyName("limit")]
    int? Limit,
    [property: JsonProperty("cursor_range")] [property: JsonPropertyName("cursor_range")]
    IReadOnlyList<string> CursorRange
);