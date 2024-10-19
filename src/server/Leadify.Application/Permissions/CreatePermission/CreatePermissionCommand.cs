using Leadify.Application.Abstraction.Messaging;

namespace Leadify.Application.Permissions.CreatePermission;

public record CreatePermissionCommand(string PermissionName) : ICommand;
