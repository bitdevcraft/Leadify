using System.Security.Cryptography;
using Leadify.Application.Abstraction.Authentication;

namespace Leadify.Infrastructure.Security.Authentication;

public class SessionProvider : ISessionProvider
{
    public string Generate()
    {
        byte[] randomNumber = new byte[32];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }
}
