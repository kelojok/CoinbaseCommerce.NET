using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models.Invoices
{
    public record InvoiceData(
        [property: JsonPropertyName("business_name")] string BusinessName,

        [property: JsonPropertyName("code")] string Code,

        [property: JsonPropertyName("created_at")] DateTime? CreatedAt,

        [property: JsonPropertyName("customer_email")] string CustomerEmail,

        [property: JsonPropertyName("customer_name")] string CustomerName,

        [property: JsonPropertyName("hosted_url")] string HostedUrl,

        [property: JsonPropertyName("id")] string Id,

        [property: JsonPropertyName("local_price")] LocalPrice LocalPrice,

        [property: JsonPropertyName("memo")] string Memo,

        [property: JsonPropertyName("resource")] string Resource,

        [property: JsonPropertyName("status")] string Status,

        [property: JsonPropertyName("updated_at")] DateTime? UpdatedAt
    );
}
