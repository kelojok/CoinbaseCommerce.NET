namespace Coinbase.Commerce.Models.Models.Currencies;

public record Local(string Amount, string Currency) : CryptoCurrency(Amount, Currency);