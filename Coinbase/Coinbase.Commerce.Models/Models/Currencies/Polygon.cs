namespace Coinbase.Commerce.Models.Models.Currencies;

public record Polygon(string Amount, string Currency) : CryptoCurrency(Amount, Currency)
{
}