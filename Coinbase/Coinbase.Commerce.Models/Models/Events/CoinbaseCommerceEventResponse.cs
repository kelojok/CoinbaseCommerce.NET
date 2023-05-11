namespace Coinbase.Commerce.Models.Models.Events;

public record CoinbaseCommerceEventResponse<T>(T? Data, MetaData? Metadata, Pagination? Pagination)
    : BaseResponse<T>(Data, Metadata, Pagination);