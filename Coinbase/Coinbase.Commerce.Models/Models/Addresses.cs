using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models
{
    public record Addresses(
        [property: JsonPropertyName("polygon")] string Polygon,

        [property: JsonPropertyName("pusdc")] string Pusdc,

        [property: JsonPropertyName("pweth")] string Pweth,

        [property: JsonPropertyName("ethereum")] string Ethereum,

        [property: JsonPropertyName("usdc")] string Usdc,

        [property: JsonPropertyName("dai")] string Dai,

        [property: JsonPropertyName("apecoin")] string Apecoin,

        [property: JsonPropertyName("shibainu")] string Shibainu,

        [property: JsonPropertyName("tether")] string Tether,

        [property: JsonPropertyName("bitcoincash")] string Bitcoincash,

        [property: JsonPropertyName("dogecoin")] string Dogecoin,

        [property: JsonPropertyName("litecoin")] string Litecoin,

        [property: JsonPropertyName("bitcoin")] string Bitcoin

    );
}
