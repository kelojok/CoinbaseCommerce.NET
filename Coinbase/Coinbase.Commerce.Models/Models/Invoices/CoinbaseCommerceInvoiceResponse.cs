namespace Coinbase.Commerce.Models.Models.Invoices;

public record CoinbaseCommerceInvoiceResponse<T>(T? Data, MetaData? Metadata, Pagination? Pagination)
    : BaseResponse<T>(Data, Metadata, Pagination);