using Coinbase.Commerce.Models.Models.Charges;
using Coinbase.Commerce.Models.Models.Queries;
using Refit;

namespace Coinbase.Commerce.Clients.Interfaces.Charges;

public interface ICoinbaseCommerceChargeClient
{
    /// <summary>
    ///     Retrieves details of a charge asynchronously by its ID.
    /// </summary>
    /// <param name="id">The ID of the charge to retrieve.</param>
    /// <returns>A task representing the asynchronous operation, returning an ApiResponse with the details of the charge.</returns>
    [Get("/charges/{id}")]
    Task<ApiResponse<CoinbaseCommerceChargeResponse<ChargeData>>> ShowChargeAsync(string id);

    /// <summary>
    ///     Retrieves a list of all charges asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning an ApiResponse with the list of charges.</returns>
    [Get("/charges/")]
    Task<ApiResponse<CoinbaseCommerceChargeResponse<List<ChargeData>>>> ListChargesAsync(
        [Query] BaseQueryOptions? options = null);

    /// <summary>
    ///     Creates a new charge asynchronously with the provided request object.
    /// </summary>
    /// <param name="request">The request object containing the necessary information to create the charge.</param>
    /// <returns>
    ///     A task representing the asynchronous operation, returning an ApiResponse with the details of the created
    ///     charge.
    /// </returns>
    [Post("/charges")]
    Task<ApiResponse<CoinbaseCommerceChargeResponse<ChargeData>>> CreateChargeAsync(
        [Body] CoinbaseCommerceChargeRequest request);

    /// <summary>
    ///     Cancels a previously created charge asynchronously.
    ///     Only new charges with an undetected payment can be successfully canceled.
    /// </summary>
    /// <param name="chargeId">The code or ID of the charge to cancel.</param>
    /// <returns>A task representing the asynchronous operation, returning an ApiResponse with the details of the cancellation.</returns>
    [Post("/charges/{chargeId}/cancel")]
    Task<ApiResponse<CoinbaseCommerceChargeResponse<ChargeData>>> CancelChargeAsync(string chargeId);

    /// <summary>
    ///     Resolves a previously marked unresolved charge asynchronously.
    /// </summary>
    /// <param name="chargeId">The code or ID of the charge to resolve.</param>
    /// <returns>A task representing the asynchronous operation, returning an ApiResponse with the details of the resolution.</returns>
    [Post("/charges/{chargeId}/resolve")]
    Task<CoinbaseCommerceChargeResponse<ChargeData>> ResolveChargeAsync(string chargeId);
}