using Coinbase.Commerce.Models.Models;
using Coinbase.Commerce.Models.Models.Invoices;
using Refit;
using System.Runtime.InteropServices;

namespace Coinbase.Commerce.Clients.Interfaces.Invoices;

public interface ICoinbaseCommerceInvoiceClient
{

    [Post("/invoices/")]
    Task<ApiResponse<CoinbaseCommerceInvoiceResponse<InvoiceData>>> CreateInvoiceAsync(CoinbaseCommerceInvoiceRequest request);

    [Get("/invoices/{invoiceId}")]
    Task<ApiResponse<CoinbaseCommerceInvoiceResponse<InvoiceData>>> ShowInvoiceAsync(string invoiceId);

    [Get("/invoices/")]
    Task<ApiResponse<CoinbaseCommerceInvoiceResponse<List<InvoiceData>>>> ListInvoicesAsync();

    /// <summary>
    ///     Cancels the payment request associated with this invoice, marking it as canceled and preventing further payments
    /// </summary>
    /// <param name="invoiceId">The invoice to cancel</param>
    /// <returns>Empty data object with any potential errors</returns>
    [Put("/invoices/{invoiceId}/void")]
    Task<IApiResponse> VoidInvoiceAsync(string invoiceId);

    /// <summary>
    ///     Resolves an invoice, confirms the payment and marks the invoice as paid.
    /// </summary>
    /// <param name="invoiceId">The invoice to resolve</param>
    /// <returns></returns>
    [Put("/invoices/{invoiceId}/resolve")]
    Task<ApiResponse<CoinbaseCommerceInvoiceResponse<InvoiceData>>> ResolveInvoiceAsync(string invoiceId);
}