using System.Net;
using Coinbase.Commerce.Api;
using Coinbase.Commerce.Clients.Interfaces.Charges;
using Coinbase.Commerce.Models.Models;
using Coinbase.Commerce.Models.Models.Charges;
using Coinbase.Commerce.Models.Models.Statuses;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace Coinbase.Commerce.Clients.Tests;

public class ChargeClientTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly ICoinbaseCommerceChargeClient _chargeClient;
    private readonly WebApplicationFactory<Program> _factory;

    public ChargeClientTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
        _chargeClient = _factory.Services.GetService<ICoinbaseCommerceChargeClient>();
    }

    [Fact]
    public async Task CreateChargeAsync_ReturnsSuccessfulResponseWithChargeInfo()
    {
        var chargeRequest = CreateDummyChargeRequest();

        var response = await _chargeClient.CreateChargeAsync(chargeRequest);

        Assert.NotNull(response.Content?.Data);
        Assert.True(response.IsSuccessStatusCode);
    }

    [Fact]
    public async Task ListChargesAsync_ReturnsSuccessfulResponseWithChargeListInfo()
    {
        var response = await _chargeClient.ListChargesAsync();

        Assert.NotNull(response.Content?.Data);
        Assert.True(response.IsSuccessStatusCode);

        // If there are no charges listed, the response body may be empty
        // and that is also considered a pass for this test.
    }

    [Fact]
    public async Task CancelChargeAsync_ReturnsSuccessfulResponseWithCanceledCharge()
    {
        var chargeRequest = CreateDummyChargeRequest();

        var response = await _chargeClient.CreateChargeAsync(chargeRequest);

        var cancelChargeResponse = await _chargeClient.CancelChargeAsync(response.Content.Data.Id);


        Assert.NotNull(cancelChargeResponse.Content?.Data);
        Assert.True(cancelChargeResponse.IsSuccessStatusCode);
        Assert.Contains(cancelChargeResponse.Content.Data.Timeline, x => x.Status == TransactionStatuses.Canceled);
    }

    [Fact]
    public async Task CreateChargeAsync_ReturnsUnsuccessfulResponse()
    {
        var chargeRequest = CreateDummyErrorChargeRequest();

        var response = await _chargeClient.CreateChargeAsync(chargeRequest);

        Assert.Null(response.Content?.Data);
        Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
    }

    private static CoinbaseCommerceChargeRequest CreateDummyChargeRequest()
    {
        return new CoinbaseCommerceChargeRequest(
            "Test charge name",
            "Test charge for integration purposes",
            "fixed_price",
            new LocalPrice("USD", "150.00"),
            new MetaData("12345", "John Doe"),
            "https://example.com/success",
            "https://example.com/cancel",
            new List<string> { "name", "email" });
    }

    private static CoinbaseCommerceChargeRequest CreateDummyErrorChargeRequest()
    {
        return new CoinbaseCommerceChargeRequest(
            "Test charge name",
            "Test charge for integration purposes",
            "error price",
            new LocalPrice("ERROR", "150.00"),
            new MetaData("12345", "John Doe"),
            "https://example.com/success",
            "https://example.com/cancel",
            new List<string> { "name", "email" });
    }
}