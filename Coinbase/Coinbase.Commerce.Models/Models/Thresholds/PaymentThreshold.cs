using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models.Thresholds;

public record PaymentThreshold(
    
    [property: JsonPropertyName("overpayment_absolute_threshold")]
    OverpaymentAbsoluteThreshold OverpaymentAbsoluteThreshold,

    [property: JsonPropertyName("overpayment_relative_threshold")]
    string OverpaymentRelativeThreshold,

    [property: JsonPropertyName("underpayment_absolute_threshold")]
    UnderpaymentAbsoluteThreshold UnderpaymentAbsoluteThreshold,

    [property: JsonPropertyName("underpayment_relative_threshold")]
    string UnderpaymentRelativeThreshold
);