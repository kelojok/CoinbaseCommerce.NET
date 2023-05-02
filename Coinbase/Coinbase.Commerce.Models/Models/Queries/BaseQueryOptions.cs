namespace Coinbase.Commerce.Models.Models.Queries;

public class BaseQueryOptions
{
    public int? Limit { get; set; } = 25;
    public string? StartingAfter { get; set; }
    public string? EndingBefore { get; set; }
    public string? Order { get; set; } = "desc";
}