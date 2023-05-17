using Coinbase.Commerce.Models.Models.Rates;
using Coinbase.Commerce.Models.Models.Thresholds;
using Newtonsoft.Json;

namespace Coinbase.Commerce.Models.Models
{
    public record Data(
    [property: JsonProperty("addresses")] Addresses Addresses,

    [property: JsonProperty("brand_color")] string BrandColor,

    [property: JsonProperty("brand_logo_url")] string BrandLogoUrl,

    [property: JsonProperty("cancel_url")] string CancelUrl,

    [property: JsonProperty("code")] string Code,

    [property: JsonProperty("coinbase_managed_merchant")] bool? CoinbaseManagedMerchant,

    [property: JsonProperty("created_at")] DateTime? CreatedAt,

    [property: JsonProperty("description")] string Description,

    [property: JsonProperty("exchange_rates")] ExchangeRates ExchangeRates,

    [property: JsonProperty("expires_at")] DateTime? ExpiresAt,

    [property: JsonProperty("fee_rate")] double? FeeRate,

    [property: JsonProperty("fees_settled")] bool? FeesSettled,

    [property: JsonProperty("hosted_url")] string HostedUrl,

    [property: JsonProperty("id")] string Id,

    [property: JsonProperty("local_exchange_rates")] LocalExchangeRates LocalExchangeRates,

    [property: JsonProperty("logo_url")] string LogoUrl,

    [property: JsonProperty("metadata")] MetaData Metadata,

    [property: JsonProperty("name")] string Name,

    [property: JsonProperty("offchain_eligible")] bool? OffchainEligible,

    [property: JsonProperty("organization_name")] string OrganizationName,

    [property: JsonProperty("payment_threshold")] PaymentThreshold PaymentThreshold,

    [property: JsonProperty("payments")] IReadOnlyList<object> Payments,

    [property: JsonProperty("pricing")] Pricing Pricing,

    [property: JsonProperty("pricing_type")] PricingType PricingType,

    [property: JsonProperty("pwcb_only")] bool? PwcbOnly,

    [property: JsonProperty("redirect_url")] string RedirectUrl,

    [property: JsonProperty("resource")] string Resource,

    [property: JsonProperty("support_email")] string SupportEmail,

    [property: JsonProperty("timeline")] IReadOnlyList<Timeline> Timeline,

    [property: JsonProperty("utxo")] bool? Utxo

    );
}
