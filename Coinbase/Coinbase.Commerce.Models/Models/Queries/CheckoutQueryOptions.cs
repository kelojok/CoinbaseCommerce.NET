namespace Coinbase.Commerce.Models.Models.Queries;

public class CheckoutQueryOptions : BaseQueryOptions
{
    public int? CustomerId { get; set; }
    public string? Status { get; set; }
    public string? Expand { get; set; }
}