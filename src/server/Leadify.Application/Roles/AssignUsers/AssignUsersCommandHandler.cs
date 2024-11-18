using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace Leadify.Application.Roles.AssignUsers;

internal sealed class AssignUsersCommandHandler(
    IRoleRepository roleRepository,
    RoleManager<Role> roleManager
) : ICommandHandler<AssignUsersCommand>
{
    private readonly IRoleRepository _roleRepository = roleRepository;
    private readonly RoleManager<Role> _roleManager = roleManager;

    public async Task<Result> Handle(
        AssignUsersCommand request,
        CancellationToken cancellationToken
    )
    {
        Role? role = await _roleManager.FindByNameAsync(request.RoleName);

        if (role is null)
        {
            return Result.Failure(Error.NotFound());
        }

        bool result = await _roleRepository.AddUsersAsync(role, request.UserId.Select(Id => Ulid.Parse(Id))) > 0;

        if (!result)
        {
            return Result.Failure(Error.Validation("Error Encountered"));
        }

        return Result.Success();
    }
}