using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public record Pagination(
    [property: JsonPropertyName("order")] string Order,

    [property: JsonPropertyName("starting_after")] string StartingAfter,

    [property: JsonPropertyName("ending_before")] string EndingBefore,

    [property: JsonPropertyName("previous_uri")] string PreviousUri,

    [property: JsonPropertyName("next_uri")] string NextUri,

    [property: JsonPropertyName("total")] int? Total,

    [property: JsonPropertyName("yielded")] int? Yielded,

    [property: JsonPropertyName("limit")] int? Limit,

    [property: JsonPropertyName("cursor_range")] IReadOnlyList<string> CursorRange
);