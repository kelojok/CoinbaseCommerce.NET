using System.Net;
using Coinbase.Commerce.Api;
using Coinbase.Commerce.Clients.Interfaces.Invoices;
using Coinbase.Commerce.Models.Models;
using Coinbase.Commerce.Models.Models.Invoices;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace Coinbase.Commerce.Clients.Tests;

public class InvoiceClientTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    private readonly ICoinbaseCommerceInvoiceClient _invoiceClient;

    public InvoiceClientTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
        _invoiceClient = _factory.Services.GetService<ICoinbaseCommerceInvoiceClient>();
    }

    [Fact]
    public async Task CreateInvoiceAsync_ReturnsSuccessfulResponseWithInvoiceInfo()
    {
        var invoiceRequest = CreateDummyInvoiceRequest();

        var response = await _invoiceClient.CreateInvoiceAsync(invoiceRequest);

        Assert.NotNull(response.Content?.Data);

        Assert.True(response.IsSuccessStatusCode);
    }

    [Fact]
    public async Task CreateInvoiceAsync_ReturnsUnsuccessfulResponseWithError()
    {
        var invoiceRequest = CreateDummyErrorInvoiceRequest();

        var response = await _invoiceClient.CreateInvoiceAsync(invoiceRequest);

        Assert.Null(response.Content?.Data);

        Assert.False(response.IsSuccessStatusCode);

        Assert.NotNull(response.Error);
    }

    [Fact]
    public async Task ShowInvoiceAsync_ReturnsSuccessfulResponseWithInvoiceInfo()
    {
        var invoiceRequest = CreateDummyInvoiceRequest();

        var response = await _invoiceClient.CreateInvoiceAsync(invoiceRequest);

        var showInvoiceResponse = await _invoiceClient.ShowInvoiceAsync(response.Content?.Data?.Id);

        Assert.NotNull(showInvoiceResponse.Content?.Data);

        Assert.True(showInvoiceResponse.IsSuccessStatusCode);
    }

    [Fact]
    public async Task ShowInvoiceAsync_ReturnsNotFoundWhenInvoiceDoesNotExist()
    {
        var showInvoiceResponse = await _invoiceClient.ShowInvoiceAsync("123456");

        Assert.Null(showInvoiceResponse.Content?.Data);

        Assert.True(showInvoiceResponse.StatusCode == HttpStatusCode.NotFound);

        Assert.NotNull(showInvoiceResponse.Error);
    }

    [Fact]
    public async Task ListInvoiceAsync_ReturnsSuccessfulResponseWithInvoicesInfo()
    {
        var response = await _invoiceClient.ListInvoicesAsync();

        Assert.NotNull(response.Content?.Data);

        Assert.True(response.IsSuccessStatusCode);
    }

    [Fact]
    public async Task VoidInvoiceAsync_ReturnsSuccessfulEmptyResponse()
    {
        var invoiceRequest = CreateDummyInvoiceRequest();

        var response = await _invoiceClient.CreateInvoiceAsync(invoiceRequest);

        var voidInvoiceResponse = await _invoiceClient.VoidInvoiceAsync(response.Content?.Data?.Id);

        Assert.True(voidInvoiceResponse.IsSuccessStatusCode);
    }

    [Fact]
    public async Task VoidInvoiceAsync_ReturnsNotFoundWhenInvoiceDoesNotExist()
    {
        var voidInvoiceResponse = await _invoiceClient.VoidInvoiceAsync("123456");

        Assert.True(voidInvoiceResponse.IsSuccessStatusCode);
    }

    private static CoinbaseCommerceInvoiceRequest CreateDummyInvoiceRequest()
    {
        return new CoinbaseCommerceInvoiceRequest(
            "My business name",
            "Customer_email@test.com",
            "John Doe",
            "memo",
            new LocalPrice(
                "USD",
                "150"
            )
        );
    }

    private static CoinbaseCommerceInvoiceRequest CreateDummyErrorInvoiceRequest()
    {
        return new CoinbaseCommerceInvoiceRequest(
            "My business name",
            "Customer_email@test.com",
            "John Doe",
            "memo",
            new LocalPrice(
                "error",
                "150"
            )
        );
    }
}