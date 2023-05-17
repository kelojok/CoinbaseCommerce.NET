using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public record MetaData(
    [property: JsonProperty("customer_id")] string CustomerId,

    [property: JsonProperty("customer_name")] string CustomerName
);