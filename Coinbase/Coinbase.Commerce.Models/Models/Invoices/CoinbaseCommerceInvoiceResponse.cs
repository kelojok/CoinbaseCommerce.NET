namespace Coinbase.Commerce.Models.Models.Invoices;

public record CoinbaseCommerceInvoiceResponse(List<Data>? Data, MetaData Metadata, Pagination? Pagination)
    : BaseResponse(Data, Metadata, Pagination);