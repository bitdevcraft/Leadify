using System.Collections;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;

namespace Leadify.Application.Permissions.ListPermission;

internal sealed class ListPermissionQueryHandler(IPermissionRepository permissionRepository)
    : IQueryHandler<ListPermissionQuery, Hashtable>
{
    private readonly IPermissionRepository _permissionRepository = permissionRepository;

    public async Task<Result<Hashtable>> Handle(
        ListPermissionQuery request,
        CancellationToken cancellationToken
    )
    {
        List<string> permissions = await _permissionRepository.GetAllAsync();

        var permissionsResponse = new Hashtable();
        foreach (string item in permissions)
        {
            string[] details = item.Split('.');
            if (details.Length != 3)
            {
                continue;
            }

            if (permissionsResponse.ContainsKey(details[1]))
            {
                var permission = permissionsResponse[details[1]] as Hashtable;
                permission?.Add(details[2], item);
            }
            else
            {
                var permission = new Hashtable { { details[2], item } };
                permissionsResponse.Add(details[1], permission);
            }
        }

        return permissionsResponse;
    }
}
