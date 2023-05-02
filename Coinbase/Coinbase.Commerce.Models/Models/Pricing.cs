using Coinbase.Commerce.Models.Models.Currencies;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models
{
    public record Pricing(
        [property: JsonProperty("local")]
        [property: JsonPropertyName("local")] Local Local,
        [property: JsonProperty("polygon")]
        [property: JsonPropertyName("polygon")] Polygon Polygon,
        [property: JsonProperty("pusdc")]
        [property: JsonPropertyName("pusdc")] Pusdc Pusdc,
        [property: JsonProperty("pweth")]
        [property: JsonPropertyName("pweth")] Pweth Pweth,
        [property: JsonProperty("ethereum")]
        [property: JsonPropertyName("ethereum")] Ethereum Ethereum,
        [property: JsonProperty("usdc")]
        [property: JsonPropertyName("usdc")] Usdc Usdc,
        [property: JsonProperty("dai")]
        [property: JsonPropertyName("dai")] Dai Dai,
        [property: JsonProperty("apecoin")]
        [property: JsonPropertyName("apecoin")] Apecoin Apecoin,
        [property: JsonProperty("shibainu")]
        [property: JsonPropertyName("shibainu")] Shibainu Shibainu,
        [property: JsonProperty("tether")]
        [property: JsonPropertyName("tether")] Tether Tether,
        [property: JsonProperty("bitcoincash")]
        [property: JsonPropertyName("bitcoincash")] Bitcoincash Bitcoincash,
        [property: JsonProperty("dogecoin")]
        [property: JsonPropertyName("dogecoin")] Dogecoin Dogecoin,
        [property: JsonProperty("litecoin")]
        [property: JsonPropertyName("litecoin")] Litecoin Litecoin,
        [property: JsonProperty("bitcoin")]
        [property: JsonPropertyName("bitcoin")] Bitcoin Bitcoin
    );
}
