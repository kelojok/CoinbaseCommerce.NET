using System.Security.Cryptography;
using System.Text;
using Coinbase.Commerce.Clients.Helpers;
using Coinbase.Commerce.Models.Models.Settings;

namespace Coinbase.Commerce.Clients.Tests.Unit_tests;

public class CoinbaseCommerceWebhookSignatureHelperTests
{
    [Fact]
    public void ComputeSignature_VerifyValidSignature_ReturnsExpectedResult()
    {
        var content = "Hello, world!";
        var secret = "my-secret-key";
        var signature = ComputeSignature(content, secret);

        var response = new HttpResponseMessage
        {
            Content = new StringContent(content)
        };

        response.Headers.Add("CC-Webhook-Signature", Convert.ToBase64String(signature));

        var apiSettings = new ApiSettings
        {
            WebhookSecret = secret
        };

        var result = CoinbaseCommerceWebhookSignatureHelper.ComputeSignature(response, apiSettings);

        Assert.Equal(BitConverter
            .ToString(signature)
            .Replace("-", "")
            .ToLower(), result);
    }

    [Fact]
    public void ComputeSignature_VerifyInvalidSignature_ThrowsException()
    {
        var content = "Hello, world!";
        var secret = "my-secret-key";
        var signature = ComputeSignature(content, "invalid-secret");

        var response = new HttpResponseMessage
        {
            Content = new StringContent(content)
        };

        response.Headers.Add("CC-Webhook-Signature", Convert.ToBase64String(signature));

        var apiSettings = new ApiSettings
        {
            WebhookSecret = secret
        };

        Assert.Throws<InvalidOperationException>(() =>
            CoinbaseCommerceWebhookSignatureHelper.ComputeSignature(response, apiSettings));
    }

    [Fact]
    public void ComputeSignature_VerifyMissingSignature_ThrowsException()
    {
        var response = new HttpResponseMessage
        {
            Content = new StringContent("Hello, world!")
        };

        var apiSettings = new ApiSettings
        {
            WebhookSecret = "my-secret-key"
        };

        Assert.Throws<InvalidOperationException>(() =>
            CoinbaseCommerceWebhookSignatureHelper.ComputeSignature(response, apiSettings));
    }

    private static byte[] ComputeSignature(string content, string secret)
    {
        using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret));
        return hmac.ComputeHash(Encoding.UTF8.GetBytes(content));
    }
}