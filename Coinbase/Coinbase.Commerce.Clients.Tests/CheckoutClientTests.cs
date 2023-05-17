using System.Net;
using Coinbase.Commerce.Api;
using Coinbase.Commerce.Clients.Interfaces.Checkouts;
using Coinbase.Commerce.Models.Models;
using Coinbase.Commerce.Models.Models.Checkouts;
using Coinbase.Commerce.Models.Models.Queries;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace Coinbase.Commerce.Clients.Tests;

public class CheckoutClientTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    private readonly ICoinbaseCommerceCheckoutClient _checkoutClient;

    public CheckoutClientTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
        _checkoutClient = _factory.Services.GetService<ICoinbaseCommerceCheckoutClient>();
    }

    [Fact]
    public async Task CreateCheckoutAsync_ReturnsSuccessfulResponseWithCheckoutInfo()
    {
        var checkoutRequest = CreateDummyCheckoutRequest();

        var response = await _checkoutClient.CreateCheckoutAsync(checkoutRequest);

        Assert.NotNull(response.Content?.Data);
        Assert.True(response.IsSuccessStatusCode);
    }

    [Fact]
    public async Task CreateCheckoutAsync_ReturnsUnsuccessfulResponseWithError()
    {
        var checkoutRequest = CreateDummyErrorCheckoutRequest();

        var response = await _checkoutClient.CreateCheckoutAsync(checkoutRequest);

        Assert.NotNull(response.Error);
        Assert.Null(response.Content?.Data);
        Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task DeleteCheckoutAsync_ReturnsSuccessfulEmptyResponse()
    {
        var checkoutRequest = CreateDummyCheckoutRequest();

        var response = await _checkoutClient.CreateCheckoutAsync(checkoutRequest);

        var deleteCheckoutResponse = await _checkoutClient.DeleteCheckoutAsync(response.Content?.Data?.Id);

        Assert.True(deleteCheckoutResponse.IsSuccessStatusCode);
    }

    [Fact]
    public async Task UpdateCheckoutAsync_ReturnsSuccessfulResponseWithUpdatedCheckoutInfo()
    {
        var updatedCheckoutName = "My Updated Checkout";

        var checkoutRequest = CreateDummyCheckoutRequest();

        var response = await _checkoutClient.CreateCheckoutAsync(checkoutRequest);

        checkoutRequest.Name = updatedCheckoutName;

        var updateCheckoutResponse = await _checkoutClient.UpdateCheckoutAsync(response.Content?.Data?.Id, checkoutRequest);

        Assert.True(updateCheckoutResponse.IsSuccessStatusCode);
        Assert.Equal(updateCheckoutResponse.Content?.Data?.Name, updatedCheckoutName);
    }

    [Fact]
    public async Task ShowCheckoutAsync_ReturnsSuccessfulResponseWithCheckoutInfo()
    {
        var checkoutRequest = CreateDummyCheckoutRequest();

        var response = await _checkoutClient.CreateCheckoutAsync(checkoutRequest);

        var showCheckoutResponse = await _checkoutClient.ShowCheckoutAsync(response.Content?.Data?.Id);

        Assert.True(showCheckoutResponse.IsSuccessStatusCode);
        Assert.NotNull(showCheckoutResponse.Content.Data);
    }

    [Fact]
    public async Task ShowCheckoutAsync_ReturnsNotFoundWhenCheckoutDoesNotExist()
    {
        var showCheckoutResponse = await _checkoutClient.ShowCheckoutAsync("abc123g7J");

        Assert.True(showCheckoutResponse.StatusCode == HttpStatusCode.NotFound);
        Assert.NotNull(showCheckoutResponse.Error);
        Assert.Null(showCheckoutResponse.Content?.Data);
    }

    [Fact]
    public async Task ListCheckoutsAsync_ReturnsSuccessfulResponseWithCheckoutsInfo()
    {
        var listCheckoutResponse = await _checkoutClient.ListCheckoutsAsync();
        Assert.True(listCheckoutResponse.IsSuccessStatusCode);
        Assert.NotNull(listCheckoutResponse.Content?.Data);
    }

    private static CoinbaseCommerceCheckoutRequest CreateDummyCheckoutRequest()
    {
        return new CoinbaseCommerceCheckoutRequest
        {
            Name = "Checkout name",
            Description = "Checkout description",
            RequestedInfo = new List<string> { "name" },
            PricingType = PricingType.FixedPrice,
            LocalPrice = new LocalPrice("USD", "150.00")
        };
    }

    private static CoinbaseCommerceCheckoutRequest CreateDummyErrorCheckoutRequest()
    {
        return new CoinbaseCommerceCheckoutRequest
        {
            Name = "Checkout name",
            Description = "Checkout description",
            RequestedInfo = new List<string> { "name" },
            PricingType = PricingType.None,
            LocalPrice = new LocalPrice("USD", "150.00")
        };
    }
}