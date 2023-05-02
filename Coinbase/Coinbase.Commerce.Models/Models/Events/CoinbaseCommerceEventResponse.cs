namespace Coinbase.Commerce.Models.Models.Events;

public record CoinbaseCommerceEventResponse
    (List<Data>? Data, MetaData Metadata, Pagination? Pagination)
    : BaseResponse(Data, Metadata, Pagination);