namespace Coinbase.Commerce.Models.Models.Rates;

public record LocalExchangeRates(string ETHUSD, string BTCUSD, string LTCUSD, string DOGEUSD, string BCHUSD,
    string USDCUSD, string DAIUSD, string APEUSD, string SHIBUSD, string USDTUSD, string PMATICUSD, string PUSDCUSD,
    string PWETHUSD) : BaseExchangeRates(ETHUSD, BTCUSD, LTCUSD, DOGEUSD, BCHUSD, USDCUSD, DAIUSD, APEUSD, SHIBUSD,
    USDTUSD, PMATICUSD, PUSDCUSD, PWETHUSD);