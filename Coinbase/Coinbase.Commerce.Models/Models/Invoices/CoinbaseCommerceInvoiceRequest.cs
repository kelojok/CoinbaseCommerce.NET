using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Invoices;

public record CoinbaseCommerceInvoiceRequest(
    [property: JsonPropertyName("business_name")] string BusinessName,

    [property: JsonPropertyName("customer_email")] string CustomerEmail,

    [property: JsonPropertyName("customer_name")] string CustomerName,

    [property: JsonPropertyName("memo")] string Memo,

    [property: JsonPropertyName("local_price")] LocalPrice LocalPrice
);