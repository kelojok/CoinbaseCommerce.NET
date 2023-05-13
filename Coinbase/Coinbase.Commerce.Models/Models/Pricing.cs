using Coinbase.Commerce.Models.Models.Currencies;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models
{
    public record Pricing(
        [property: JsonPropertyName("local")] Local Local,

        [property: JsonPropertyName("polygon")] Polygon Polygon,

        [property: JsonPropertyName("pusdc")] Pusdc Pusdc,

        [property: JsonPropertyName("pweth")] Pweth Pweth,

        [property: JsonPropertyName("ethereum")] Ethereum Ethereum,

        [property: JsonPropertyName("usdc")] Usdc Usdc,

        [property: JsonPropertyName("dai")] Dai Dai,

        [property: JsonPropertyName("apecoin")] Apecoin Apecoin,

        [property: JsonPropertyName("shibainu")] Shibainu Shibainu,

        [property: JsonPropertyName("tether")] Tether Tether,

        [property: JsonPropertyName("bitcoincash")] Bitcoincash Bitcoincash,

        [property: JsonPropertyName("dogecoin")] Dogecoin Dogecoin,

        [property: JsonPropertyName("litecoin")] Litecoin Litecoin,

        [property: JsonPropertyName("bitcoin")] Bitcoin Bitcoin
    );
}
