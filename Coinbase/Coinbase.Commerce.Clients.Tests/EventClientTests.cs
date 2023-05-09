using Coinbase.Commerce.Api;
using Coinbase.Commerce.Clients.Interfaces.Events;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace Coinbase.Commerce.Clients.Tests;

public class EventClientTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly ICoinbaseCommerceEventClient _eventClient;
    private readonly WebApplicationFactory<Program> _factory;

    public EventClientTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
        _eventClient = _factory.Services.GetService<ICoinbaseCommerceEventClient>();
    }

    [Fact]
    public async Task ListEventsAsync_ReturnsSuccessfulResponseWithEventsInfo()
    {
        var response = await _eventClient.ListEventsAsync();

        Assert.NotNull(response.Content?.Data);
        Assert.True(response.IsSuccessStatusCode);
    }

    [Fact]
    public async Task ShowEventAsync_ReturnsSuccessfulResponseWithEventInfo()
    {
        var response = await _eventClient.ShowEventAsync("402e730d-78fe-4a1e-8691-1acfadec3c32");
    }
}