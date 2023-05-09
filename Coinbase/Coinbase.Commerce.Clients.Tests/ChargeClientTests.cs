using System.Net;
using Coinbase.Commerce.Api;
using Coinbase.Commerce.Clients.Interfaces.Charges;
using Coinbase.Commerce.Models.Models;
using Coinbase.Commerce.Models.Models.Charges;
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
