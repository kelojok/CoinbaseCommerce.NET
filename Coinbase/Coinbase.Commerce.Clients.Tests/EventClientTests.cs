using System.Net;
using Coinbase.Commerce.Api;
using Coinbase.Commerce.Clients.Interfaces.Events;
using Coinbase.Commerce.Models.Models.Queries;
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
    public async Task ListEventsAsync_ReturnsSuccessfulResponseWithEmptyData()
    {
        var paginationEnd = false;
        var eventsResponse = await _eventClient.ListEventsAsync(new BaseQueryOptions
        {
            Limit = 100
        });


        while (!paginationEnd)
            if (eventsResponse.Content?.Pagination?.NextUri == null)
                paginationEnd = true;
            else
                eventsResponse = await _eventClient.ListEventsAsync(new BaseQueryOptions
                {
                    Limit = 100,
                    StartingAfter = eventsResponse.Content.Pagination.CursorRange.LastOrDefault()
                });

        Assert.Equal(eventsResponse.Content.Data.Capacity, 0);
        Assert.Equal(eventsResponse.Content.Pagination.Yielded, 0);
        Assert.True(eventsResponse.IsSuccessStatusCode);
    }

    [Fact]
    public async Task ShowEventAsync_ReturnsSuccessfulResponseWithEventInfo()
    {
        var eventsResponse = await _eventClient.ListEventsAsync();

        var eventResponse = await _eventClient.ShowEventAsync(eventsResponse.Content.Data.FirstOrDefault().Id);

        Assert.NotNull(eventResponse.Content?.Data);
        Assert.True(eventResponse.IsSuccessStatusCode);
    }

    [Fact]
    public async Task ShowEventAsync_ReturnsUnsuccessfulResponseIfEventDoesNotExist()
    {
        var eventResponse = await _eventClient.ShowEventAsync("50FBA097-AC51-488A-AACE-04638944BE0B");

        Assert.Null(eventResponse.Content?.Data);
        Assert.True(eventResponse.StatusCode == HttpStatusCode.NotFound);
    }
}