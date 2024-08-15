using Leadify.Application.Abstraction.Authorization;
using Leadify.Domain.Shared;

namespace Leadify.Infrastructure.Security.Authorization;

public class AuthorizationService : IAuthorizationService
{
    public async Task<Result> AuthorizeCurrentUser(
        List<string> requiredRoles,
        List<string> requiredPermissions,
        List<string> requiredPolicies
    )
    {
        return Result.Success();
    }
}
