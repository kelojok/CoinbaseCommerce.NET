using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Refit;

namespace Coinbase.Commerce.Models.Models.Queries;

public class BaseQueryOptions
{
    [AliasAs("limit")]
    public int? Limit { get; set; } = 25;

    [AliasAs("starting_after")]
    public string? StartingAfter { get; set; }

    [AliasAs("ending_after")]
    public string? EndingBefore { get; set; }

    [AliasAs("order")]
    public string? Order { get; set; } = "desc";
}