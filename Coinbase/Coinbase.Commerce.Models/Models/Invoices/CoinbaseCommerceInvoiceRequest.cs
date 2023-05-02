using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Invoices;

public record CoinbaseCommerceInvoiceRequest(
    [property: JsonProperty("business_name")] [property: JsonPropertyName("business_name")]
    string BusinessName,
    [property: JsonProperty("customer_email")] [property: JsonPropertyName("customer_email")]
    string CustomerEmail,
    [property: JsonProperty("customer_name")] [property: JsonPropertyName("customer_name")]
    string CustomerName,
    [property: JsonProperty("memo")] [property: JsonPropertyName("memo")]
    string Memo,
    [property: JsonProperty("local_price")] [property: JsonPropertyName("local_price")]
    LocalPrice LocalPrice
);