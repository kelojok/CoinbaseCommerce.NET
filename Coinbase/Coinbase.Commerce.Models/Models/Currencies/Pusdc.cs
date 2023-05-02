namespace Coinbase.Commerce.Models.Models.Currencies;

public record Pusdc(string Amount, string Currency) : CryptoCurrency(Amount, Currency);