using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public record MetaData(
    [property: JsonProperty("customer_id")] [property: JsonPropertyName("customer_id")]
    string CustomerId,
    [property: JsonProperty("customer_name")] [property: JsonPropertyName("customer_name")]
    string CustomerName
);