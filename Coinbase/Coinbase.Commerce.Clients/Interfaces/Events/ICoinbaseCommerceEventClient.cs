using Coinbase.Commerce.Models.Models;
using Coinbase.Commerce.Models.Models.Events;
using Refit;

namespace Coinbase.Commerce.Clients.Interfaces.Events;

public interface ICoinbaseCommerceEventClient
{
    [Get("/events/")]
    Task<ApiResponse<CoinbaseCommerceEventResponse<List<EventData<Data>>>>> ListEventsAsync();
    [Get("/events/{eventId}")]
    Task<ApiResponse<CoinbaseCommerceEventResponse<EventData<Data>>>> ShowEventAsync(string eventId);
}