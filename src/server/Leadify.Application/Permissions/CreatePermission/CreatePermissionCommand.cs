using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Constants;

namespace Leadify.Application.Permissions.CreatePermission;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record CreatePermissionCommand(string PermissionName) : ICommand;