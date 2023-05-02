namespace Coinbase.Commerce.Models.Models.Currencies;

public record Usdc(string Amount, string Currency) : CryptoCurrency(Amount, Currency);