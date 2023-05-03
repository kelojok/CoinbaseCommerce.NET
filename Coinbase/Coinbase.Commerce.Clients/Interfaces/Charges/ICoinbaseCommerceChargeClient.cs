using Coinbase.Commerce.Models.Models.Charges;
using Refit;

namespace Coinbase.Commerce.Clients.Interfaces.Charges;

public interface ICoinbaseCommerceChargeClient : ICoinbaseCommerceApi<ApiResponse<CoinbaseCommerceChargeResponse>>
{
    /// <summary>
    ///     A charge represents a specific payment attempt and contains information such as the amount paid, currency and
    ///     status.
    /// </summary>
    /// <param name="transactionType">Charge, checkout, invoice or event. Helps set correct URL</param>
    /// <param name="request">The object that the API will process</param>
    /// <returns>Details of the charge</returns>
    [Post("/{transactionType}")]
    Task<ApiResponse<CoinbaseCommerceChargeResponse>> CreateChargeAsync(string transactionType,
        [Body] CoinbaseCommerceChargeRequest request);


    /// <summary>
    ///     Cancels a charge that has been previously created.
    ///     Only new charges with an undetected payment can be successfully canceled.
    /// </summary>
    /// <param name="chargeId">Code or ID of charge</param>
    /// <returns>Details of the cancellation</returns>
    [Post("/charges/{chargeId}/cancel")]
    Task<ApiResponse<CoinbaseCommerceChargeResponse>> CancelChargeAsync(string chargeId);

    /// <summary>
    ///     Resolves a charge that has been previously marked as unresolved.
    /// </summary>
    /// <param name="chargeId">Code or ID of charge</param>
    /// <returns>Details of the resolve</returns>
    [Post("/charges/{chargeId}/resolve")]
    Task<CoinbaseCommerceChargeResponse> ResolveChargeAsync(string chargeId);
}