using Coinbase.Commerce.Clients.Handlers;
using Coinbase.Commerce.Clients.Interfaces.Charges;
using Coinbase.Commerce.Clients.Interfaces.Checkouts;
using Coinbase.Commerce.Clients.Interfaces.Events;
using Coinbase.Commerce.Clients.Interfaces.Invoices;
using Coinbase.Commerce.Models.Models.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Coinbase.Commerce.Clients.Extensions;

public static class CoinbaseCommerceServiceExtensions
{
    public static IServiceCollection AddCoinbaseCommerceClients(
        this IServiceCollection services, IConfiguration config)
    {
        services.Configure<ApiSettings>(config);

        var apiSettings = config.Get<ApiSettings>();

        services.AddSingleton(apiSettings);

        services.AddTransient<AuthHeaderHandler>();

        services.AddRefitClient<ICoinbaseCommerceChargeClient>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiSettings.ApiBaseUrl))
            .AddHttpMessageHandler<AuthHeaderHandler>();

        services.AddRefitClient<ICoinbaseCommerceCheckoutClient>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiSettings.ApiBaseUrl))
            .AddHttpMessageHandler<AuthHeaderHandler>();

        services.AddRefitClient<ICoinbaseCommerceInvoiceClient>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiSettings.ApiBaseUrl))
            .AddHttpMessageHandler<AuthHeaderHandler>();
        services.AddRefitClient<ICoinbaseCommerceEventClient>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiSettings.ApiBaseUrl))
            .AddHttpMessageHandler<AuthHeaderHandler>();

        return services;
    }
}