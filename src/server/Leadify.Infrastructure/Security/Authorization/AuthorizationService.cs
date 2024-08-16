using Leadify.Application.Abstraction.Authorization;
using Leadify.Domain.Shared;

namespace Leadify.Infrastructure.Security.Authorization;

public class AuthorizationService : IAuthorizationService
{
    public Task<Result> AuthorizeCurrentUser(
        List<string> requiredRoles,
        List<string> requiredPermissions,
        List<string> requiredPolicies
    )
    {
        return Task.FromResult(Result.Success());
    }
}
