namespace Coinbase.Commerce.Models.Models.Checkouts;

public record CoinbaseCommerceCheckoutResponse(List<Data>? Data, MetaData? Metadata, Pagination? Pagination)
    : BaseResponse(Data, Metadata, Pagination);