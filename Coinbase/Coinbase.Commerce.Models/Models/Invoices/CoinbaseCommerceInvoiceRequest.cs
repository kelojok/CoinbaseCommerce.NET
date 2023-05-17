using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Invoices;

public record CoinbaseCommerceInvoiceRequest(
    [property: JsonProperty("business_name")] string BusinessName,

    [property: JsonProperty("customer_email")] string CustomerEmail,

    [property: JsonProperty("customer_name")] string CustomerName,

    [property: JsonProperty("memo")] string Memo,

    [property: JsonProperty("local_price")] LocalPrice LocalPrice
);