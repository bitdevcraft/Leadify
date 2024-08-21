using Leadify.Application.Abstraction.Messaging;

namespace Leadify.Application.Roles.AssignPermission;

public record AssignPermissionCommand(string RoleName, IEnumerable<string> PermissionNames)
    : ICommand;
