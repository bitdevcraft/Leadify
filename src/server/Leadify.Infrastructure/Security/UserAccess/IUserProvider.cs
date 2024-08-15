namespace Leadify.Infrastructure.Security.UserAccess;

internal interface IUserProvider
{
    Task<HashSet<string>> GetUserRolesAsync(Guid Id);
    Task<HashSet<string>> GetUserPermissionAsync(Guid Id);
}
