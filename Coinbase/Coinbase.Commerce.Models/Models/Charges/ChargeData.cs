using System.Text.Json.Serialization;
using Coinbase.Commerce.Models.Models.Rates;
using Coinbase.Commerce.Models.Models.Thresholds;

namespace Coinbase.Commerce.Models.Models.Charges
{

    public record ChargeData(
        [property: JsonPropertyName("addresses")] Addresses Addresses,

        [property: JsonPropertyName("cancel_url")] string CancelUrl,

        [property: JsonPropertyName("code")] string Code,

        [property: JsonPropertyName("created_at")] DateTime? CreatedAt,

        [property: JsonPropertyName("description")] string Description,

        [property: JsonPropertyName("exchange_rates")] ExchangeRates ExchangeRates,

        [property: JsonPropertyName("expires_at")] DateTime? ExpiresAt,

        [property: JsonPropertyName("fee_rate")] double? FeeRate,

        [property: JsonPropertyName("fees_settled")] bool? FeesSettled,

        [property: JsonPropertyName("hosted_url")] string HostedUrl,

        [property: JsonPropertyName("id")] string Id,

        [property: JsonPropertyName("local_exchange_rates")] LocalExchangeRates LocalExchangeRates,

        [property: JsonPropertyName("logo_url")] string LogoUrl,

        [property: JsonPropertyName("metadata")] MetaData Metadata,

        [property: JsonPropertyName("name")] string Name,

        [property: JsonPropertyName("offchain_eligible")] bool? OffchainEligible,

        [property: JsonPropertyName("organization_name")] string OrganizationName,

        [property: JsonPropertyName("payment_threshold")] PaymentThreshold PaymentThreshold,

        [property: JsonPropertyName("payments")] IReadOnlyList<object> Payments,

        [property: JsonPropertyName("pricing")] Pricing Pricing,

        [property: JsonPropertyName("pricing_type")] PricingType PricingType,

        [property: JsonPropertyName("pwcb_only")] bool? PwcbOnly,

        [property: JsonPropertyName("redirect_url")] string RedirectUrl,

        [property: JsonPropertyName("resource")] string Resource,

        [property: JsonPropertyName("support_email")] string SupportEmail,

        [property: JsonPropertyName("timeline")] IReadOnlyList<Timeline> Timeline,

        [property: JsonPropertyName("utxo")] bool? Utxo
    ) : BrandData;

}
