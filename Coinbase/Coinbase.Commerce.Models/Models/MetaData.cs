using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models;

public record MetaData(
    [property: JsonPropertyName("customer_id")] string CustomerId,

    [property: JsonPropertyName("customer_name")] string CustomerName
);