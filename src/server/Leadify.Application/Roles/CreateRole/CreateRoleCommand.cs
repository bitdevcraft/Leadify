using Leadify.Application.Abstraction.Messaging;

namespace Leadify.Application.Roles.CreateRole;

public sealed record class CreateRoleCommand(string RoleName) : ICommand;