using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Application.Common.PermissionType;
using Leadify.Domain.Constants;

namespace Leadify.Application.Users.ListUser;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record ListUserQuery() : IQuery<List<UserListDto>>;