using Coinbase.Commerce.Models.Models.Rates;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Coinbase.Commerce.Models.Models.Thresholds;

namespace Coinbase.Commerce.Models.Models
{
    public record Data(
    [property: JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("addresses")] Addresses Addresses,

    [property: JsonProperty("brand_color", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("brand_color")] string BrandColor,

    [property: JsonProperty("brand_logo_url", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("brand_logo_url")] string BrandLogoUrl,

    [property: JsonProperty("cancel_url", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("cancel_url")] string CancelUrl,

    [property: JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("code")] string Code,

    [property: JsonProperty("coinbase_managed_merchant", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("coinbase_managed_merchant")] bool? CoinbaseManagedMerchant,

    [property: JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("created_at")] DateTime? CreatedAt,

    [property: JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("description")] string Description,

    [property: JsonProperty("exchange_rates", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("exchange_rates")] ExchangeRates ExchangeRates,

    [property: JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("expires_at")] DateTime? ExpiresAt,

    [property: JsonProperty("fee_rate", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("fee_rate")] double? FeeRate,

    [property: JsonProperty("fees_settled", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("fees_settled")] bool? FeesSettled,

    [property: JsonProperty("hosted_url", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("hosted_url")] string HostedUrl,

    [property: JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("id")] string Id,

    [property: JsonProperty("local_exchange_rates", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("local_exchange_rates")] LocalExchangeRates LocalExchangeRates,

    [property: JsonProperty("logo_url", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("logo_url")] string LogoUrl,

    [property: JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("metadata")] MetaData Metadata,

    [property: JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("name")] string Name,

    [property: JsonProperty("offchain_eligible", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("offchain_eligible")] bool? OffchainEligible,

    [property: JsonProperty("organization_name", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("organization_name")] string OrganizationName,

    [property: JsonProperty("payment_threshold", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("payment_threshold")] PaymentThreshold PaymentThreshold,

    [property: JsonProperty("payments", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("payments")] IReadOnlyList<object> Payments,

    [property: JsonProperty("pricing", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("pricing")] Pricing Pricing,

    [property: JsonProperty("pricing_type", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("pricing_type")] string PricingType,

    [property: JsonProperty("pwcb_only", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("pwcb_only")] bool? PwcbOnly,

    [property: JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("redirect_url")] string RedirectUrl,

    [property: JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("resource")] string Resource,

    [property: JsonProperty("support_email", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("support_email")] string SupportEmail,

    [property: JsonProperty("timeline", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("timeline")] IReadOnlyList<Timeline> Timeline,

    [property: JsonProperty("utxo", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("utxo")] bool? Utxo,

    // Todo: Might need to move the below values and remove nullvaluehandling depending on results later.
    [property: JsonProperty("business_name", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("business_name")] string BusinessName,

    [property: JsonProperty("customer_email", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("customer_email")] string CustomerEmail,

    [property: JsonProperty("customer_name", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("customer_name")] string CustomerName,

    [property: JsonProperty("local_price", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("local_price")] LocalPrice LocalPrice,

    [property: JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("memo")] string Memo,

    [property: JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("status")] string Status,

    [property: JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
    [property: JsonPropertyName("updated_at")] DateTime? UpdatedAt
    );
}
