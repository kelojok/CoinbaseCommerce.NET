namespace Coinbase.Commerce.Models.Models.Thresholds;

public record UnderpaymentAbsoluteThreshold(string Amount, string Currency)
    : BasePaymentAbsoluteThreshold(Amount, Currency);