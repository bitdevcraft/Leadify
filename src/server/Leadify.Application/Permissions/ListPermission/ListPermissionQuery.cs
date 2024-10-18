using System.Collections;
using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Constants;

namespace Leadify.Application.Permissions.ListPermission;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record ListPermissionQuery : IQuery<Hashtable>;