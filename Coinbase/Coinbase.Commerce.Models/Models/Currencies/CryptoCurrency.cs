using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Currencies;

public record CryptoCurrency
(
    [property: JsonPropertyName("amount")] string Amount,

    [property: JsonPropertyName("currency")] string Currency
);