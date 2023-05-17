using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Queries;

public class BaseQueryOptions
{
    [JsonProperty("limit")]
    public int? Limit { get; set; } = 25;

    [JsonProperty("starting_after")]
    public string? StartingAfter { get; set; }

    [JsonProperty("ending_after")]
    public string? EndingBefore { get; set; }

    [JsonProperty("order")]
    public string? Order { get; set; } = "desc";
}