using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public record BaseResponse<T>(
    [property: JsonProperty("data")] T? Data,

    [property: JsonProperty("metadata")] MetaData Metadata,

    [property: JsonProperty("pagination")] Pagination? Pagination);