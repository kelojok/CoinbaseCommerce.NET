using Coinbase.Commerce.Models.Models.Queries;
using Refit;

namespace Coinbase.Commerce.Clients.Interfaces;

public interface ICoinbaseCommerceApi<TResponse>
{

    /// <summary>
    /// Show one of four available transaction types
    /// </summary>
    /// <param name="transactionType">Charge, checkout, invoice or event</param>
    /// <param name="id">The id</param>
    /// <returns>Details of the transaction</returns>
    [Get("/{transactionType}/{id}")]
    Task<TResponse> ShowAsync(string transactionType, string id);

    /// <summary>
    /// List all for one of four available transaction types
    /// </summary>
    /// <typeparam name="TOption">Query options like sorting</typeparam>
    /// <param name="transactionType">Charge, checkout, invoice or event</param>
    /// <param name="options"></param>
    /// <returns>Details of the transaction</returns>
    [Get("/{transactionType}")]
    Task<TResponse> ListAllAsync<TOption>(string transactionType, [Query] TOption options)
        where TOption : BaseQueryOptions;
}