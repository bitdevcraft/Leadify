using Leadify.Application.Abstraction.Messaging;

namespace Leadify.Application.Roles.DeleteRole;

public record DeleteRoleCommand(string Name) : ICommand;