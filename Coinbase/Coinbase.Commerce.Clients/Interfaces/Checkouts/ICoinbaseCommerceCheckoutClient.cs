﻿using Coinbase.Commerce.Models.Models.Checkouts;
using Refit;

namespace Coinbase.Commerce.Clients.Interfaces.Checkouts;

public interface ICoinbaseCommerceCheckoutClient : ICoinbaseCommerceApi<ApiResponse<CoinbaseCommerceCheckoutResponse>>
{
    /// <summary>
    ///     Create and customize a Coinbase Commerce-hosted payment (checkout) page
    /// </summary>
    /// <param name="transactionType">Charge, checkout, invoice or event. Helps set correct URL</param>
    /// <param name="request">The request</param>
    /// <returns>Details of the created checkout</returns>
    [Headers("Content-Type: application/json")]
    [Post("/checkouts")]
    Task<ApiResponse<CoinbaseCommerceCheckoutResponse>> CreateCheckoutAsync(string transactionType,
        [Body] CoinbaseCommerceCheckoutRequest request);

    /// <summary>
    ///     Update a Coinbase Commerce-hosted payment (checkout) page
    /// </summary>
    /// <param name="checkoutId">The checkout id</param>
    /// <returns>Details of the updated checkout</returns>
    [Put("/checkouts/{checkoutId}")]
    Task<ApiResponse<CoinbaseCommerceCheckoutResponse>> UpdateCheckoutAsync(string checkoutId);

    /// <summary>
    ///     Delete a Coinbase Commerce-hosted payment (checkout) page
    /// </summary>
    /// <param name="checkoutId">The checkout id</param>
    /// <returns>Details of the deleted checkout</returns>
    [Delete("/checkouts/{checkoutId}")]
    Task<IApiResponse> DeleteCheckoutAsync(string checkoutId);
}