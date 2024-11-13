using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Constants;

namespace Leadify.Application.Roles.CreateRole;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public sealed record class CreateRoleCommand(string RoleName) : ICommand;