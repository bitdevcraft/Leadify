using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Constants;

namespace Leadify.Application.Roles.AssignUsers;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record AssignUsersCommand(string RoleName, IEnumerable<string> UserId) : ICommand;