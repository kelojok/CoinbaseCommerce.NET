using System.Security.Cryptography;
using System.Text;
using Coinbase.Commerce.Models.Models.Settings;

namespace Coinbase.Commerce.Clients.Helpers;

public static class CoinbaseCommerceWebhookSignatureHelper
{
    /// <summary>
    ///     Verifies the webhook signature before acting on it
    /// </summary>
    /// <param name="response"></param>
    /// <param name="apiSettings"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    public static string ComputeSignature(HttpResponseMessage response, ApiSettings apiSettings)
    {
        if (response == null) throw new ArgumentNullException(nameof(response));

        if (apiSettings == null) throw new ArgumentNullException(nameof(apiSettings));

        if (string.IsNullOrEmpty(apiSettings.WebhookSecret))
            throw new InvalidOperationException("Webhook secret is not configured.");

        var content = response.Content.ReadAsByteArrayAsync().Result;
        var signatureHeader = response.Headers.GetValues("CC-Webhook-Signature").FirstOrDefault();

        if (string.IsNullOrEmpty(signatureHeader))
            throw new InvalidOperationException("CC-Webhook-Signature header is not present in the response.");

        var signature = Convert.FromBase64String(signatureHeader);
        var secret = Encoding.UTF8.GetBytes(apiSettings.WebhookSecret);

        using var hmac = new HMACSHA256(secret);
        var hash = hmac.ComputeHash(content);

        if (!signature.SequenceEqual(hash))
            throw new InvalidOperationException("Invalid CC-Webhook-Signature header.");

        return BitConverter
            .ToString(hash)
            .Replace("-", "")
            .ToLower();
    }
}