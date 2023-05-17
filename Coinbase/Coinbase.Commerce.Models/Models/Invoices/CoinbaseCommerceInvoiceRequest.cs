using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Invoices;

public class CoinbaseCommerceInvoiceRequest
{
    [JsonProperty("business_name")]
    public string BusinessName { get; set; }

    [JsonProperty("customer_email")]
    public string CustomerEmail { get; set; }

    [JsonProperty("customer_name")]
    public string CustomerName { get; set; }

    [JsonProperty("memo")]
    public string Memo { get; set; }

    [JsonProperty("local_price")]
    public LocalPrice LocalPrice { get; set; }
}
