using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public record Timeline(
    [property: JsonProperty("status")] [property: JsonPropertyName("status")]
    string Status,
    [property: JsonProperty("time")] [property: JsonPropertyName("time")]
    DateTime? Time
);