using Coinbase.Commerce.Models.Models.Events;
using Refit;

namespace Coinbase.Commerce.Clients.Interfaces.Events;

public interface ICoinbaseCommerceEventClient : ICoinbaseCommerceApi<ApiResponse<CoinbaseCommerceEventResponse>>
{
}