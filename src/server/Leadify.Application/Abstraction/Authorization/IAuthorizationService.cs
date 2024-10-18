using Leadify.Domain.Shared;

namespace Leadify.Application.Abstraction.Authorization;

public interface IAuthorizationService
{
    Task<Result> AuthorizeCurrentUser(
        ICollection<string> requiredRoles,
        ICollection<string> requiredPermissions,
        ICollection<string> requiredPolicies
    );
}