using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models
{
    public record Addresses(
        [property: JsonProperty("polygon")] string Polygon,

        [property: JsonProperty("pusdc")] string Pusdc,

        [property: JsonProperty("pweth")] string Pweth,

        [property: JsonProperty("ethereum")] string Ethereum,

        [property: JsonProperty("usdc")] string Usdc,

        [property: JsonProperty("dai")] string Dai,

        [property: JsonProperty("apecoin")] string Apecoin,

        [property: JsonProperty("shibainu")] string Shibainu,

        [property: JsonProperty("tether")] string Tether,

        [property: JsonProperty("bitcoincash")] string Bitcoincash,

        [property: JsonProperty("dogecoin")] string Dogecoin,

        [property: JsonProperty("litecoin")] string Litecoin,

        [property: JsonProperty("bitcoin")] string Bitcoin

    );
}
