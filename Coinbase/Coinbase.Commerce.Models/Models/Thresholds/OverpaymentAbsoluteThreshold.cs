namespace Coinbase.Commerce.Models.Models.Thresholds;

public record OverpaymentAbsoluteThreshold(string Amount, string Currency)
    : BasePaymentAbsoluteThreshold(Amount, Currency);