using Leadify.Domain.Users;

namespace Leadify.Domain.Repositories;

public interface IRoleRepository
{
    Task<int> AddToPermissionAsync(Role role, IEnumerable<string> permissionName);
    Task<int> AddUsersAsync(Role role, IEnumerable<Ulid> userIds);
    Task<Role?> GetRoleByNameAsync(string role, CancellationToken cancellationToken = default);
}