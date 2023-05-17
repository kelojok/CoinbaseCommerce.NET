using Coinbase.Commerce.Models.Models.Settings;

namespace Coinbase.Commerce.Clients.Handlers;

public class AuthHeaderHandler : DelegatingHandler
{
    private readonly ApiSettings _apiSettings;

    public AuthHeaderHandler(ApiSettings apiSettings)
    {
        _apiSettings = apiSettings;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        AddRequiredHeaders(request);

        return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
    }

    public static implicit operator Func<object>(AuthHeaderHandler v)
    {
        throw new NotImplementedException();
    }

    public void AddRequiredHeaders(HttpRequestMessage request)
    {
        request.Headers.Add("Accept", "application/json");
        request.Headers.Add("X-CC-Api-Key", _apiSettings.ApiKey);
        request.Headers.Add("X-CC-Version", _apiSettings.ApiVersion);
    }
}