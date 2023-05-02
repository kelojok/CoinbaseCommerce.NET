namespace Coinbase.Commerce.Models.Models.Currencies;

public record Tether(string Amount, string Currency) : CryptoCurrency(Amount, Currency);