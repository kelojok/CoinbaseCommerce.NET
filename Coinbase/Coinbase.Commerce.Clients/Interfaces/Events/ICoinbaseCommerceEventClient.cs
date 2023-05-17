using Coinbase.Commerce.Models.Models;
using Coinbase.Commerce.Models.Models.Events;
using Coinbase.Commerce.Models.Models.Queries;
using Refit;

namespace Coinbase.Commerce.Clients.Interfaces.Events;

public interface ICoinbaseCommerceEventClient
{
    /// <summary>
    ///     Retrieves a list of events asynchronously, with optional query options.
    /// </summary>
    /// <param name="options">Optional query options to filter or paginate the list of events.</param>
    /// <returns>A task representing the asynchronous operation, returning an ApiResponse with the list of events.</returns>
    [Get("/events/")]
    Task<ApiResponse<CoinbaseCommerceEventResponse<List<EventData<Data>>>>> ListEventsAsync(
        [Query] BaseQueryOptions? options = null);

    /// <summary>
    ///     Retrieves an event asynchronously by its ID.
    /// </summary>
    /// <param name="eventId">The ID of the event to retrieve.</param>
    /// <returns>A task representing the asynchronous operation, returning an ApiResponse with the retrieved event data.</returns>
    [Get("/events/{eventId}")]
    Task<ApiResponse<CoinbaseCommerceEventResponse<EventData<Data>>>> ShowEventAsync(string eventId);
}