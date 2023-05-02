using Coinbase.Commerce.Models.Models.Rates;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models
{
    public record Data(
        [property: JsonProperty("addresses")]
        [property: JsonPropertyName("addresses")] Addresses Addresses,

        [property: JsonProperty("brand_color")]
        [property: JsonPropertyName("brand_color")] string BrandColor,

        [property: JsonProperty("brand_logo_url")]
        [property: JsonPropertyName("brand_logo_url")] string BrandLogoUrl,

        [property: JsonProperty("cancel_url")]
        [property: JsonPropertyName("cancel_url")] string CancelUrl,

        [property: JsonProperty("code")]
        [property: JsonPropertyName("code")] string Code,

        [property: JsonProperty("coinbase_managed_merchant")]
        [property: JsonPropertyName("coinbase_managed_merchant")] bool? CoinbaseManagedMerchant,

        [property: JsonProperty("created_at")]
        [property: JsonPropertyName("created_at")] DateTime? CreatedAt,

        [property: JsonProperty("description")]
        [property: JsonPropertyName("description")] string Description,

        [property: JsonProperty("exchange_rates")]
        [property: JsonPropertyName("exchange_rates")] ExchangeRates ExchangeRates,

        [property: JsonProperty("expires_at")]
        [property: JsonPropertyName("expires_at")] DateTime? ExpiresAt,

        [property: JsonProperty("fee_rate")]
        [property: JsonPropertyName("fee_rate")] double? FeeRate,

        [property: JsonProperty("fees_settled")]
        [property: JsonPropertyName("fees_settled")] bool? FeesSettled,

        [property: JsonProperty("hosted_url")]
        [property: JsonPropertyName("hosted_url")] string HostedUrl,

        [property: JsonProperty("id")]
        [property: JsonPropertyName("id")] string Id,

        [property: JsonProperty("local_exchange_rates")]
        [property: JsonPropertyName("local_exchange_rates")] LocalExchangeRates LocalExchangeRates,

        [property: JsonProperty("logo_url")]
        [property: JsonPropertyName("logo_url")] string LogoUrl,

        [property: JsonProperty("metadata")]
        [property: JsonPropertyName("metadata")] MetaData Metadata,

        [property: JsonProperty("name")]
        [property: JsonPropertyName("name")] string Name,

        [property: JsonProperty("offchain_eligible")]
        [property: JsonPropertyName("offchain_eligible")] bool? OffchainEligible,

        [property: JsonProperty("organization_name")]
        [property: JsonPropertyName("organization_name")] string OrganizationName,

        [property: JsonProperty("payment_threshold")]
        [property: JsonPropertyName("payment_threshold")] PaymentThreshold PaymentThreshold,

        [property: JsonProperty("payments")]
        [property: JsonPropertyName("payments")] IReadOnlyList<object> Payments,

        [property: JsonProperty("pricing")]
        [property: JsonPropertyName("pricing")] Pricing Pricing,

        [property: JsonProperty("pricing_type")]
        [property: JsonPropertyName("pricing_type")] string PricingType,

        [property: JsonProperty("pwcb_only")]
        [property: JsonPropertyName("pwcb_only")] bool? PwcbOnly,

        [property: JsonProperty("redirect_url")]
        [property: JsonPropertyName("redirect_url")] string RedirectUrl,

        [property: JsonProperty("resource")]
        [property: JsonPropertyName("resource")] string Resource,

        [property: JsonProperty("support_email")]
        [property: JsonPropertyName("support_email")] string SupportEmail,

        [property: JsonProperty("timeline")]
        [property: JsonPropertyName("timeline")] IReadOnlyList<Timeline> Timeline,

        [property: JsonProperty("utxo")]
        [property: JsonPropertyName("utxo")] bool? Utxo
    );
}
