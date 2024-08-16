using Leadify.Domain.Users;

namespace Leadify.Domain.Repositories;

public interface IPermissionRepository
{
    Task<Permission?> FindByNameAsync(string name);
    Task<int> CreateAsync(string name);
    Task<int> DeleteAsync(Permission permission);
    Task<List<string>> GetAllByRoleIdAsync(string Id);
    Task<HashSet<string>> GetAllByUserIdAsync(string Id);
}
