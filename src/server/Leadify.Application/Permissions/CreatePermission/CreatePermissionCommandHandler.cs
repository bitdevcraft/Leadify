using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;

namespace Leadify.Application.Permissions.CreatePermission;

internal sealed class CreatePermissionCommandHandler(IPermissionRepository permissionRepository)
    : ICommandHandler<CreatePermissionCommand>
{
    private readonly IPermissionRepository _permissionRepository = permissionRepository;

    public async Task<Result> Handle(
        CreatePermissionCommand request,
        CancellationToken cancellationToken
    )
    {
        Permission? exists = await _permissionRepository.FindByNameAsync(request.PermissionName);

        if (exists != null)
        {
            return Result.Failure(Error.Validation("Permission Name Exists"));
        }

        bool result = await _permissionRepository.CreateAsync(request.PermissionName) > 0;

        if (result is false)
        {
            return Result.Failure(Error.Validation("Failed to create Permission"));
        }

        return Result.Success();
    }
}