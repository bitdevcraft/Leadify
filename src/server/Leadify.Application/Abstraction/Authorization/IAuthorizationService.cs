using Leadify.Domain.Shared;

namespace Leadify.Application.Abstraction.Authorization;

public interface IAuthorizationService
{
    //
    Task<Result> AuthorizeCurrentUser(
        List<string> requiredRoles,
        List<string> requiredPermissions,
        List<string> requiredPolicies
    );
}
