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
