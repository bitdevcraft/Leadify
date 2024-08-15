using Microsoft.AspNetCore.Identity;

namespace Leadify.Infrastructure.Security.UserAccess;

public class UserRoles
{
    Guid Id { get; set; }
    public List<string> Roles { get; set; } = [];
}
