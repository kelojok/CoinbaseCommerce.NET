namespace Coinbase.Commerce.Models.Models.Charges;

public record CoinbaseCommerceChargeResponse<T>(T? Data, MetaData? Metadata, Pagination? Pagination)
    : BaseResponse<T>(Data, Metadata, Pagination);