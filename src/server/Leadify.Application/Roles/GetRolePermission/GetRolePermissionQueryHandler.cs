using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace Leadify.Application.Roles.GetRolePermission;

internal sealed class GetRolePermissionQueryHandler(
    IPermissionRepository permissionRepository,
    RoleManager<Role> roleManager
) : IQueryHandler<GetRolePermissionQuery, List<string>>
{
    private readonly IPermissionRepository _permissionRepository = permissionRepository;
    private readonly RoleManager<Role> _roleManager = roleManager;

    public async Task<Result<List<string>>> Handle(
        GetRolePermissionQuery request,
        CancellationToken cancellationToken
    )
    {
        Role? role = await _roleManager.FindByNameAsync(request.RoleName);

        if (role is null)
        {
            return Result.Failure<List<string>>(Error.NotFound());
        }

        List<string> permissions = await _permissionRepository.GetAllByRoleIdAsync(
            role.Id.ToString()
        );

        return permissions;
    }
}