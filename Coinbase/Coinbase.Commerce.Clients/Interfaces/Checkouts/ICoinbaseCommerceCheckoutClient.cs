using Coinbase.Commerce.Models.Models.Checkouts;
using Coinbase.Commerce.Models.Models.Queries;
using Refit;

namespace Coinbase.Commerce.Clients.Interfaces.Checkouts;

public interface ICoinbaseCommerceCheckoutClient
{
    /// <summary>
    /// Shows a Coinbase Commerce-hosted payment (checkout) page
    /// </summary>
    /// <param name="checkoutId">The checkout id</param>
    /// <returns></returns>
    [Get("/checkouts/{checkoutId}")]
    Task<ApiResponse<CoinbaseCommerceCheckoutResponse<CheckoutData>>> ShowCheckoutAsync(string checkoutId);

    /// <summary>
    /// Lists all Coinbase Commerce-hosted payment (checkout) pages
    /// </summary>
    /// <returns></returns>
    [Get("/checkouts/")]
    Task<ApiResponse<CoinbaseCommerceCheckoutResponse<List<CheckoutData>>>> ListCheckoutsAsync([Query] CheckoutQueryOptions? options = null);


    /// <summary>
    ///     Create and customize a Coinbase Commerce-hosted payment (checkout) page
    /// </summary>
    /// <param name="transactionType">Charge, checkout, invoice or event. Helps set correct URL</param>
    /// <param name="request">The request</param>
    /// <returns>Details of the created checkout</returns>
    [Headers("Content-Type: application/json")]
    [Post("/checkouts")]
    Task<ApiResponse<CoinbaseCommerceCheckoutResponse<CheckoutData>>> CreateCheckoutAsync([Body] CoinbaseCommerceCheckoutRequest request);

    /// <summary>
    ///     Update a Coinbase Commerce-hosted payment (checkout) page
    /// </summary>
    /// <param name="checkoutId">The checkout id</param>
    /// <returns>Details of the updated checkout</returns>
    [Put("/checkouts/{checkoutId}")]
    Task<ApiResponse<CoinbaseCommerceCheckoutResponse<CheckoutData>>> UpdateCheckoutAsync(string checkoutId);

    /// <summary>
    ///     Delete a Coinbase Commerce-hosted payment (checkout) page
    /// </summary>
    /// <param name="checkoutId">The checkout id</param>
    /// <returns>Details of the deleted checkout</returns>
    [Delete("/checkouts/{checkoutId}")]
    Task<IApiResponse> DeleteCheckoutAsync(string checkoutId);
}