using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public record Pagination(
    [property: JsonProperty("order")] string Order,

    [property: JsonProperty("starting_after")] string StartingAfter,

    [property: JsonProperty("ending_before")] string EndingBefore,

    [property: JsonProperty("previous_uri")] string PreviousUri,

    [property: JsonProperty("next_uri")] string NextUri,

    [property: JsonProperty("total")] int? Total,

    [property: JsonProperty("yielded")] int? Yielded,

    [property: JsonProperty("limit")] int? Limit,

    [property: JsonProperty("cursor_range")] IReadOnlyList<string> CursorRange
);