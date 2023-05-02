using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models.Thresholds;

public record PaymentThreshold(
    [property: JsonProperty("overpayment_absolute_threshold")]
    [property: JsonPropertyName("overpayment_absolute_threshold")]
    OverpaymentAbsoluteThreshold OverpaymentAbsoluteThreshold,
    [property: JsonProperty("overpayment_relative_threshold")]
    [property: JsonPropertyName("overpayment_relative_threshold")]
    string OverpaymentRelativeThreshold,
    [property: JsonProperty("underpayment_absolute_threshold")]
    [property: JsonPropertyName("underpayment_absolute_threshold")]
    UnderpaymentAbsoluteThreshold UnderpaymentAbsoluteThreshold,
    [property: JsonProperty("underpayment_relative_threshold")]
    [property: JsonPropertyName("underpayment_relative_threshold")]
    string UnderpaymentRelativeThreshold
);