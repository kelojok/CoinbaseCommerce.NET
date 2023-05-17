using Coinbase.Commerce.Models.Models.Charges;
using Coinbase.Commerce.Models.Models.Queries;
using Refit;

namespace Coinbase.Commerce.Clients.Interfaces.Charges;

public interface ICoinbaseCommerceChargeClient
{

    /// <summary>
    /// Shows a charge
    /// </summary>
    /// <param name="id">The identifier</param>
    /// <returns></returns>
    [Get("/charges/{id}")]
    Task<ApiResponse<CoinbaseCommerceChargeResponse<ChargeData>>> ShowChargeAsync(string id);

    /// <summary>
    /// Shows a list of all charges
    /// </summary>
    /// <returns></returns>
    [Get("/charges/")]
    Task<ApiResponse<CoinbaseCommerceChargeResponse<List<ChargeData>>>> ListChargesAsync([Query] BaseQueryOptions? options = null);

    /// <summary>
    ///     A charge represents a specific payment attempt and contains information such as the amount paid, currency and
    ///     status.
    /// </summary>
    /// <param name="request">The object that the API will process</param>
    /// <returns>Details of the charge</returns>
    [Post("/charges")]
    Task<ApiResponse<CoinbaseCommerceChargeResponse<ChargeData>>> CreateChargeAsync([Body] CoinbaseCommerceChargeRequest request);


    /// <summary>
    ///     Cancels a charge that has been previously created.
    ///     Only new charges with an undetected payment can be successfully canceled.
    /// </summary>
    /// <param name="chargeId">Code or ID of charge</param>
    /// <returns>Details of the cancellation</returns>
    [Post("/charges/{chargeId}/cancel")]
    Task<ApiResponse<CoinbaseCommerceChargeResponse<ChargeData>>> CancelChargeAsync(string chargeId);

    /// <summary>
    ///     Resolves a charge that has been previously marked as unresolved.
    /// </summary>
    /// <param name="chargeId">Code or ID of charge</param>
    /// <returns>Details of the resolve</returns>
    [Post("/charges/{chargeId}/resolve")]
    Task<CoinbaseCommerceChargeResponse<ChargeData>> ResolveChargeAsync(string chargeId);
}