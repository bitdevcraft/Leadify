using Leadify.Application.Abstraction.Messaging;

namespace Leadify.Application.Roles.GetRolePermission;

public record GetRolePermissionQuery(string RoleName) : IQuery<List<string>>;