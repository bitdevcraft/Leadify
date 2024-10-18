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
    private readonly ICacheService _cacheService = cacheService;
    private readonly ApplicationDbContext _context = context;
    private readonly IPermissionRepository _permissionRepository = permissionRepository;
    private readonly IUserContext _userContext = userContext;

    public async Task<Result> AuthorizeCurrentUser(
        ICollection<string> requiredRoles,
        ICollection<string> requiredPermissions,
        ICollection<string> requiredPolicies
    )
    {
        try
        {
            string identityId = _userContext.IdentityId;
            // Get User Roles
            HashSet<string> permissions = await GetUserPermission(identityId);
            if (requiredPermissions.Intersect(permissions).Any())
            {
                return Result.Success();
            }

            // Get User Permissions
            HashSet<string> roles = await GetUserRoles(identityId);
            if (requiredRoles.Intersect(roles).Any())
            {
                return Result.Success();
            }
        }
        catch
        {
            return Result.Failure(Error.Unauthorized("No User Found"));
        }

        return Result.Failure(Error.Unauthorized("The User didn't meet the required permission"));
    }

    private async Task<HashSet<string>> GetUserRoles(string identityId)
    {
        string cacheKey = $"auth:roles-{identityId}";

        HashSet<string>? cacheRoles = await _cacheService.GetAsync<HashSet<string>>(cacheKey);

        if (cacheRoles is not null)
        {
            return cacheRoles;
        }

        var roles = _context
            .Set<UserRole>()
            .Where(x => x.UserId == Ulid.Parse(identityId))
            .Select(x => x.Role.ToString())
            .ToHashSet();

        await _cacheService.SetAsync(cacheKey, roles, TimeSpan.FromMinutes(5));

        return roles;
    }

    private async Task<HashSet<string>> GetUserPermission(string identityId)
    {
        string cacheKey = $"auth:permissions-{identityId}";

        HashSet<string>? cachePermissions = await _cacheService.GetAsync<HashSet<string>>(cacheKey);

        if (cachePermissions is not null)
        {
            return cachePermissions;
        }

        HashSet<string> permissions = await _permissionRepository.GetAllByUserIdAsync(identityId);

        await _cacheService.SetAsync(cacheKey, permissions, TimeSpan.FromMinutes(5));

        return permissions;
    }
}