namespace Coinbase.Commerce.Models.Models.Currencies;

public record Dogecoin(string Amount, string Currency) : CryptoCurrency(Amount, Currency);