using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models;

public enum PricingType
{
    [EnumMember(Value = "none")] None,

    [EnumMember(Value = "fixed_price")] FixedPrice,

    [EnumMember(Value = "flexible_price")] FlexiblePrice
}