using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models
{
    public record Addresses(
        [property: JsonProperty("polygon")]
        [property: JsonPropertyName("polygon")] string Polygon,
        [property: JsonProperty("pusdc")]
        [property: JsonPropertyName("pusdc")] string Pusdc,
        [property: JsonProperty("pweth")]
        [property: JsonPropertyName("pweth")] string Pweth,
        [property: JsonProperty("ethereum")]
        [property: JsonPropertyName("ethereum")] string Ethereum,
        [property: JsonProperty("usdc")]
        [property: JsonPropertyName("usdc")] string Usdc,
        [property: JsonProperty("dai")]
        [property: JsonPropertyName("dai")] string Dai,
        [property: JsonProperty("apecoin")]
        [property: JsonPropertyName("apecoin")] string Apecoin,
        [property: JsonProperty("shibainu")]
        [property: JsonPropertyName("shibainu")] string Shibainu,
        [property: JsonProperty("tether")]
        [property: JsonPropertyName("tether")] string Tether,
        [property: JsonProperty("bitcoincash")]
        [property: JsonPropertyName("bitcoincash")] string Bitcoincash,
        [property: JsonProperty("dogecoin")]
        [property: JsonPropertyName("dogecoin")] string Dogecoin,
        [property: JsonProperty("litecoin")]
        [property: JsonPropertyName("litecoin")] string Litecoin,
        [property: JsonProperty("bitcoin")]
        [property: JsonPropertyName("bitcoin")] string Bitcoin
    );
}
