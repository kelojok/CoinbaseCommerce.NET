namespace Coinbase.Commerce.Models.Models.Currencies;

public record Pweth(string Amount, string Currency) : CryptoCurrency(Amount, Currency);