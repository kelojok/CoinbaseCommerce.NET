## CoinbaseCommerce.NET
## Project Description

The Coinbase Commerce API is a payment gateway that allows businesses to accept cryptocurrency payments from customers. This project provides Refit interfaces that can be used to communicate with the Coinbase Commerce API.

## Installation

To use this in your own project you must:

 - Get your own API key at Coinbase Commerce by registering a new user and go to the settings section.
 - Paste the API key in the appsettings json file.
 - Register all clients. Look at the program.cs file in the test API project for an example of how to do that.

## Usage

 `Refit` NuGet is used for all clients. Once installed, you can create an instance of the `ICoinbaseCommerceChargeClient` interface and use its methods to communicate with the Coinbase Commerce API.

Here's an example of how you can use the `ICoinbaseCommerceChargeClient` interface to create a new charge:

    var client = RestService.For<ICoinbaseCommerceChargeClient>("https://api.commerce.coinbase.com");
    
    var request = new CoinbaseCommerceChargeRequest(
        name: "My Product",
        description: "A description of my product",
        pricingType: PricingType.FixedPrice,
        localPrice: new LocalPrice(
            amount: "10.00",
            currency: "USD"
        ),
        metadata: new MetaData(
            new Dictionary<string, string> {
                { "order_id", "123" }
            }
        ),
        redirectUrl: "https://example.com/redirect",
        cancelUrl: "https://example.com/cancel",
        requestedInfo: new List<string>()
    );
    
    var response = await client.CreateChargeAsync(request);
    
    if (response.IsSuccessStatusCode)
    {
        var charge = response.Content.Data;
        Console.WriteLine($"Charge created with ID: {charge.Id}");
    }
    else
    {
        Console.WriteLine($"Error creating charge: {response.Error}");
    }

The other clients are quite similar but the request should always be adapted to the client you plan on using.

## Contributing

Contributions are highly appreciated!

## License

MIT license

## Acknowledgements

Refit deserved a mention I suppose!

## Support
[![Buy me a beer :)](https://i.postimg.cc/NMd00Qgr/beer-time.jpg)](https://www.buymeacoffee.com/jonkel)

## Links

Commerce API Docs ([Welcome | Coinbase Cloud](https://docs.cloud.coinbase.com/commerce/docs/welcome))
