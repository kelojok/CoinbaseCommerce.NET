namespace Coinbase.Commerce.Models.Models.Currencies;

public record Dai(string Amount, string Currency) : CryptoCurrency(Amount, Currency);