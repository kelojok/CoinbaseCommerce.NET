using Coinbase.Commerce.Models.Models.Currencies;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models
{
    public record Pricing(
        [property: JsonProperty("local")] Local Local,

        [property: JsonProperty("polygon")] Polygon Polygon,

        [property: JsonProperty("pusdc")] Pusdc Pusdc,

        [property: JsonProperty("pweth")] Pweth Pweth,

        [property: JsonProperty("ethereum")] Ethereum Ethereum,

        [property: JsonProperty("usdc")] Usdc Usdc,

        [property: JsonProperty("dai")] Dai Dai,

        [property: JsonProperty("apecoin")] Apecoin Apecoin,

        [property: JsonProperty("shibainu")] Shibainu Shibainu,

        [property: JsonProperty("tether")] Tether Tether,

        [property: JsonProperty("bitcoincash")] Bitcoincash Bitcoincash,

        [property: JsonProperty("dogecoin")] Dogecoin Dogecoin,

        [property: JsonProperty("litecoin")] Litecoin Litecoin,

        [property: JsonProperty("bitcoin")] Bitcoin Bitcoin
    );
}
