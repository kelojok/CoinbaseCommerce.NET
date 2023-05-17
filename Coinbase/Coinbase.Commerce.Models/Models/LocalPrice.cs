using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public record LocalPrice(
    [property: JsonProperty("currency")] string Currency,

    [property: JsonProperty("amount")] string Amount
);