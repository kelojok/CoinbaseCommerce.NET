using Coinbase.Commerce.Models.Models.Invoices;
using Coinbase.Commerce.Models.Models.Queries;
using Refit;

namespace Coinbase.Commerce.Clients.Interfaces.Invoices;

public interface ICoinbaseCommerceInvoiceClient
{
    /// <summary>
    ///     Creates a new invoice asynchronously.
    /// </summary>
    /// <param name="request">The invoice request object containing the required information.</param>
    /// <returns>A task representing the asynchronous operation, returning an ApiResponse with the created invoice data.</returns>
    [Post("/invoices/")]
    Task<ApiResponse<CoinbaseCommerceInvoiceResponse<InvoiceData>>> CreateInvoiceAsync(
        CoinbaseCommerceInvoiceRequest request);

    /// <summary>
    ///     Retrieves an invoice asynchronously by its ID.
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to retrieve.</param>
    /// <returns>A task representing the asynchronous operation, returning an ApiResponse with the retrieved invoice data.</returns>
    [Get("/invoices/{invoiceId}")]
    Task<ApiResponse<CoinbaseCommerceInvoiceResponse<InvoiceData>>> ShowInvoiceAsync(string invoiceId);

    /// <summary>
    ///     Retrieves a list of invoices asynchronously, with optional query options.
    /// </summary>
    /// <param name="options">Optional query options to filter or paginate the list of invoices.</param>
    /// <returns>A task representing the asynchronous operation, returning an ApiResponse with the list of invoices.</returns>
    [Get("/invoices/")]
    Task<ApiResponse<CoinbaseCommerceInvoiceResponse<List<InvoiceData>>>> ListInvoicesAsync(
        [Query] BaseQueryOptions? options = null);

    /// <summary>
    ///     Cancels the payment request associated with this invoice, marking it as canceled and preventing further payments.
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to cancel.</param>
    /// <returns>A task representing the asynchronous operation, returning an IApiResponse.</returns>
    [Put("/invoices/{invoiceId}/void")]
    Task<IApiResponse> VoidInvoiceAsync(string invoiceId);

    /// <summary>
    ///     Resolves an invoice, confirms the payment, and marks the invoice as paid.
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to resolve.</param>
    /// <returns>A task representing the asynchronous operation, returning an ApiResponse with the resolved invoice data.</returns>
    [Put("/invoices/{invoiceId}/resolve")]
    Task<ApiResponse<CoinbaseCommerceInvoiceResponse<InvoiceData>>> ResolveInvoiceAsync(string invoiceId);
}