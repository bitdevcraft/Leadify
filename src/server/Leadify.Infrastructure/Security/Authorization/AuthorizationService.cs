using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Caching;
using Leadify.Application.Abstraction.UserAccess;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;
using Leadify.Persistence;

namespace Leadify.Infrastructure.Security.Authorization;

public class AuthorizationService(
    IUserContext userContext,
    ICacheService cacheService,
    ApplicationDbContext context,
    IPermissionRepository permissionRepository
) : IAuthorizationService
{
    private readonly IUserContext _userContext = userContext;
    private readonly ICacheService _cacheService = cacheService;
    private readonly ApplicationDbContext _context = context;
    private readonly IPermissionRepository _permissionRepository = permissionRepository;

    public async Task<Result> AuthorizeCurrentUser(
        List<string> requiredRoles,
        List<string> requiredPermissions,
        List<string> requiredPolicies
    )
    {
        var identityId = _userContext.IdentityId;

        // Get User Roles
        var permissions = await GetUserPermission(identityId);
        if (requiredPermissions.Intersect(permissions).Any())
        {
            return Result.Success();
        }

        // Get User Permissions
        var roles = await GetUserRoles(identityId);
        if (requiredRoles.Intersect(roles).Any())
        {
            return Result.Success();
        }

        return Result.Failure(Error.Unauthorized());
    }

    private async Task<HashSet<string>> GetUserRoles(string identityId)
    {
        var cacheKey = $"auth:roles-{identityId}";

        var cacheRoles = await _cacheService.GetAsync<HashSet<string>>(cacheKey);

        if (cacheRoles is not null)
        {
            return cacheRoles;
        }

        var roles = _context
            .Set<UserRole>()
            .Where(x => x.UserId == Ulid.Parse(identityId))
            .Select(x => x.Role.ToString())
            .ToHashSet();

        await _cacheService.SetAsync(cacheKey, roles);

        return roles;
    }

    private async Task<HashSet<string>> GetUserPermission(string identityId)
    {
        var cacheKey = $"auth:permissions-{identityId}";

        var cachePermissions = await _cacheService.GetAsync<HashSet<string>>(cacheKey);

        if (cachePermissions is not null)
        {
            return cachePermissions;
        }

        var permissions = await _permissionRepository.GetAllByUserIdAsync(identityId);

        await _cacheService.SetAsync(cacheKey, permissions);

        return permissions;
    }
}
