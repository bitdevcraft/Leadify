using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;

namespace Leadify.Application.Permissions.ListPermission;

internal sealed class ListPermissionQueryHandler(IPermissionRepository permissionRepository)
    : IQueryHandler<ListPermissionQuery, List<string>>
{
    private readonly IPermissionRepository _permissionRepository = permissionRepository;

    public async Task<Result<List<string>>> Handle(
        ListPermissionQuery request,
        CancellationToken cancellationToken
    ) => await _permissionRepository.GetAllAsync();
}
