namespace Coinbase.Commerce.Models.Models.Charges;

public record CoinbaseCommerceChargeResponse(List<Data>? Data, MetaData Metadata, Pagination? Pagination)
    : BaseResponse(Data, Metadata, Pagination);