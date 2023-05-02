namespace Coinbase.Commerce.Models.Models.Currencies;

public record Bitcoin(string Amount, string Currency) : CryptoCurrency(Amount, Currency);