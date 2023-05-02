namespace Coinbase.Commerce.Models.Models.Currencies;

public record Apecoin(string Amount, string Currency) : CryptoCurrency(Amount, Currency);