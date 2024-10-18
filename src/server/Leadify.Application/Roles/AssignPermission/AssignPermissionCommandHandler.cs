using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace Leadify.Application.Roles.AssignPermission;

internal sealed class AssignPermissionCommandHandler(
    RoleManager<Role> roleManager,
    IRoleRepository roleRepository
) : ICommandHandler<AssignPermissionCommand>
{
    private readonly RoleManager<Role> _roleManager = roleManager;
    private readonly IRoleRepository _roleRepository = roleRepository;

    public async Task<Result> Handle(
        AssignPermissionCommand request,
        CancellationToken cancellationToken
    )
    {
        Role? role = await _roleManager.FindByNameAsync(request.RoleName);

        if (role is null)
        {
            return Result.Failure(Error.NotFound());
        }

        bool result = await _roleRepository.AddToPermissionAsync(role, request.PermissionNames) > 0;

        if (result is false)
        {
            return Result.Failure(Error.Validation("Error Encountered"));
        }

        return Result.Success();
    }
}