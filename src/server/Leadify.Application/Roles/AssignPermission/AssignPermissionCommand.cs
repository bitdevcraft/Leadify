using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Application.Common.PermissionType;
using Leadify.Domain.Constants;

namespace Leadify.Application.Roles.AssignPermission;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record AssignPermissionCommand(string RoleName, IEnumerable<string> PermissionNames)
    : ICommand;