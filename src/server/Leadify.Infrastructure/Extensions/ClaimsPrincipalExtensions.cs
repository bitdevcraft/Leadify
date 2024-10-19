using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Leadify.Infrastructure.Extensions;

internal static class ClaimsPrincipalExtensions
{
    public static string GetIdentityId(this ClaimsPrincipal? principal) =>
        principal?.FindFirstValue(ClaimTypes.NameIdentifier)
        ?? throw new ArgumentException("User identity is unavailable");

    public static Guid GetUserId(this ClaimsPrincipal? principal)
    {
        string? userId = principal?.FindFirstValue(JwtRegisteredClaimNames.Sub);

        return Guid.TryParse(userId, out Guid parsedUserId)
            ? parsedUserId
            : throw new ArgumentException("User identifier is unavailable");
    }
}
