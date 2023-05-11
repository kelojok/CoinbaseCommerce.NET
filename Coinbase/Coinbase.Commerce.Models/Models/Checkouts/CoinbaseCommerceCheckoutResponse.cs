namespace Coinbase.Commerce.Models.Models.Checkouts;

public record CoinbaseCommerceCheckoutResponse<T>(T? Data, MetaData? Metadata, Pagination? Pagination)
    : BaseResponse<T>(Data, Metadata, Pagination);