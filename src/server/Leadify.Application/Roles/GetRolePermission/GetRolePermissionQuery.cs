using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Constants;

namespace Leadify.Application.Roles.GetRolePermission;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record GetRolePermissionQuery(string RoleName) : IQuery<List<string>>;