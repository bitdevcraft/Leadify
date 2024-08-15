using Leadify.Application.Abstraction.Caching;
using Leadify.Domain.Users;
using Leadify.Persistence;
using Microsoft.AspNetCore.Identity;

namespace Leadify.Infrastructure.Security.UserAccess;

public class UserProvider : IUserProvider
{
    public Task<HashSet<string>> GetUserPermissionAsync(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<HashSet<string>> GetUserRolesAsync(Guid Id)
    {
        throw new NotImplementedException();
    }
}
