using Leadify.Application.Abstraction.Authorization;
using Leadify.Domain.Constants;
using Leadify.Domain.Shared;
using MediatR;

namespace Leadify.Application.Users.CreateUser;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public sealed record CreateUserCommand(UserDto User)
    : IRequest<Result<Unit>>;