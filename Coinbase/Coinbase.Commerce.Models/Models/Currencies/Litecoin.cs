namespace Coinbase.Commerce.Models.Models.Currencies;

public record Litecoin(string Amount, string Currency) : CryptoCurrency(Amount, Currency)
{
}