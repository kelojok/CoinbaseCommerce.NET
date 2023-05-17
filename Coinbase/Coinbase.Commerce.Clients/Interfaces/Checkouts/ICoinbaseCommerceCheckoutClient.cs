using Coinbase.Commerce.Models.Models.Checkouts;
using Coinbase.Commerce.Models.Models.Queries;
using Refit;

namespace Coinbase.Commerce.Clients.Interfaces.Checkouts;

public interface ICoinbaseCommerceCheckoutClient
{
    /// <summary>
    ///     Retrieves a Coinbase Commerce-hosted payment (checkout) page asynchronously by its ID.
    /// </summary>
    /// <param name="checkoutId">The ID of the checkout page to retrieve.</param>
    /// <returns>A task representing the asynchronous operation, returning an ApiResponse with the retrieved checkout data.</returns>
    [Get("/checkouts/{checkoutId}")]
    Task<ApiResponse<CoinbaseCommerceCheckoutResponse<CheckoutData>>> ShowCheckoutAsync(string checkoutId);

    /// <summary>
    ///     Retrieves a list of all Coinbase Commerce-hosted payment (checkout) pages asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning an ApiResponse with the list of checkout pages.</returns>
    [Get("/checkouts/")]
    Task<ApiResponse<CoinbaseCommerceCheckoutResponse<List<CheckoutData>>>> ListCheckoutsAsync(
        [Query] CheckoutQueryOptions? options = null);

    /// <summary>
    ///     Creates and customizes a Coinbase Commerce-hosted payment (checkout) page asynchronously.
    /// </summary>
    /// <param name="transactionType">
    ///     The type of transaction (Charge, Checkout, Invoice, or Event) to help set the correct
    ///     URL.
    /// </param>
    /// <param name="request">The request object containing the necessary information to create the checkout page.</param>
    /// <returns>
    ///     A task representing the asynchronous operation, returning an ApiResponse with the details of the created
    ///     checkout page.
    /// </returns>
    [Headers("Content-Type: application/json")]
    [Post("/checkouts")]
    Task<ApiResponse<CoinbaseCommerceCheckoutResponse<CheckoutData>>> CreateCheckoutAsync(
        [Body] CoinbaseCommerceCheckoutRequest request);

    /// <summary>
    ///     Updates a Coinbase Commerce-hosted payment (checkout) page asynchronously.
    /// </summary>
    /// <param name="checkoutId">The ID of the checkout page to update.</param>
    /// <param name="request">The request object containing the updated information for the checkout page.</param>
    /// <returns>
    ///     A task representing the asynchronous operation, returning an ApiResponse with the details of the updated
    ///     checkout page.
    /// </returns>
    [Put("/checkouts/{checkoutId}")]
    Task<ApiResponse<CoinbaseCommerceCheckoutResponse<CheckoutData>>> UpdateCheckoutAsync(string checkoutId,
        [Body] CoinbaseCommerceCheckoutRequest request);

    /// <summary>
    ///     Deletes a Coinbase Commerce-hosted payment (checkout) page asynchronously.
    /// </summary>
    /// <param name="checkoutId">The ID of the checkout page to delete.</param>
    /// <returns>
    ///     A task representing the asynchronous operation, returning an IApiResponse indicating the success or failure of
    ///     the deletion.
    /// </returns>
    [Delete("/checkouts/{checkoutId}")]
    Task<IApiResponse> DeleteCheckoutAsync(string checkoutId);
}