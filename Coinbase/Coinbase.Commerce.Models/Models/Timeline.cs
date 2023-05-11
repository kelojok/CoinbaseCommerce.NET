using System.Text.Json.Serialization;
using Coinbase.Commerce.Models.Models.Statuses;

namespace Coinbase.Commerce.Models.Models;

public record Timeline(
    [property: JsonPropertyName("status")] TransactionStatuses Status,

    [property: JsonPropertyName("time")] DateTime? Time
);