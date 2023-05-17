using Coinbase.Commerce.Clients.Handlers;
using Coinbase.Commerce.Clients.Interfaces.Charges;
using Coinbase.Commerce.Clients.Interfaces.Checkouts;
using Coinbase.Commerce.Clients.Interfaces.Events;
using Coinbase.Commerce.Clients.Interfaces.Invoices;
using Coinbase.Commerce.Models.Models.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
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

        JsonConvert.DefaultSettings = () => new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Converters = { new StringEnumConverter() }
        };

        services.AddRefitClient<ICoinbaseCommerceChargeClient>(new RefitSettings(new NewtonsoftJsonContentSerializer()))
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiSettings.ApiBaseUrl))
            .AddHttpMessageHandler<AuthHeaderHandler>();

        services.AddRefitClient<ICoinbaseCommerceCheckoutClient>(
                new RefitSettings(new NewtonsoftJsonContentSerializer()))
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiSettings.ApiBaseUrl))
            .AddHttpMessageHandler<AuthHeaderHandler>();

        services.AddRefitClient<ICoinbaseCommerceInvoiceClient>(
                new RefitSettings(new NewtonsoftJsonContentSerializer()))
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiSettings.ApiBaseUrl))
            .AddHttpMessageHandler<AuthHeaderHandler>();
        services.AddRefitClient<ICoinbaseCommerceEventClient>(new RefitSettings(new NewtonsoftJsonContentSerializer()))
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiSettings.ApiBaseUrl))
            .AddHttpMessageHandler<AuthHeaderHandler>();

        return services;
    }
}