using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Invoices
{
    public record InvoiceData(
        [property: JsonProperty("business_name")] string BusinessName,

        [property: JsonProperty("code")] string Code,

        [property: JsonProperty("created_at")] DateTime? CreatedAt,

        [property: JsonProperty("customer_email")] string CustomerEmail,

        [property: JsonProperty("customer_name")] string CustomerName,

        [property: JsonProperty("hosted_url")] string HostedUrl,

        [property: JsonProperty("id")] string Id,

        [property: JsonProperty("local_price")] LocalPrice LocalPrice,

        [property: JsonProperty("memo")] string Memo,

        [property: JsonProperty("resource")] string Resource,

        [property: JsonProperty("status")] string Status,

        [property: JsonProperty("updated_at")] DateTime? UpdatedAt
    );
}
