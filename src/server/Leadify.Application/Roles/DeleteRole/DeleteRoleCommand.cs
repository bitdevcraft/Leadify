using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Constants;

namespace Leadify.Application.Roles.DeleteRole;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record DeleteRoleCommand(string Name) : ICommand;