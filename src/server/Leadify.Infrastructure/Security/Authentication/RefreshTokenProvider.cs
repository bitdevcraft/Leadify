using System.Security.Cryptography;
using Leadify.Application.Abstraction.Authentication;

namespace Leadify.Infrastructure.Security.Authentication;

internal sealed class RefreshTokenProvider : IRefreshTokenProvider
{
#pragma warning disable CA1822
    public string GenerateRefreshToken()
#pragma warning restore CA1822
    {
        byte[] randomNumber = new byte[32];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }
}