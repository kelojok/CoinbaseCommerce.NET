namespace Coinbase.Commerce.Models.Models.Currencies;

public record Ethereum(string Amount, string Currency) : CryptoCurrency(Amount, Currency);