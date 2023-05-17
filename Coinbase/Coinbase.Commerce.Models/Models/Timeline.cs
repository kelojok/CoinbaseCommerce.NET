using Coinbase.Commerce.Models.Models.Statuses;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public record Timeline(
    [property: JsonProperty("status")] TransactionStatuses Status,

    [property: JsonProperty("time")] DateTime? Time
);