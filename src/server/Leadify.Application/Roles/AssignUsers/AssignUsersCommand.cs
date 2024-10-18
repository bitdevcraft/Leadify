using Leadify.Application.Abstraction.Messaging;

namespace Leadify.Application.Roles.AssignUsers;

public record AssignUsersCommand(string RoleName, IEnumerable<string> UserId) : ICommand;