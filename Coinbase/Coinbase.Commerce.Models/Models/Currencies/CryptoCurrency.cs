using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Currencies;

public record CryptoCurrency
(
    [property: JsonProperty("amount")] string Amount,

    [property: JsonProperty("currency")] string Currency
);