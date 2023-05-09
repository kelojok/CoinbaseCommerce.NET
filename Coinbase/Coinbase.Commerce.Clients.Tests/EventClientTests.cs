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
