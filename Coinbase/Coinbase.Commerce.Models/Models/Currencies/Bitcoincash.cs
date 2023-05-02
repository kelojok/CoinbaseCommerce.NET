namespace Coinbase.Commerce.Models.Models.Currencies;

public record Bitcoincash(string Amount, string Currency) : CryptoCurrency(Amount, Currency);