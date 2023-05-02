namespace Coinbase.Commerce.Models.Models.Currencies;

public record Shibainu(string Amount, string Currency) : CryptoCurrency(Amount, Currency);