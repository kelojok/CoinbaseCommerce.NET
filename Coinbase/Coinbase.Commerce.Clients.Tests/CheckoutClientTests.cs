using System.Net;
using Coinbase.Commerce.Api;
using Coinbase.Commerce.Clients.Interfaces.Checkouts;
using Coinbase.Commerce.Models.Models;
using Coinbase.Commerce.Models.Models.Checkouts;
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
