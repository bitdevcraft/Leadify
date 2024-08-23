using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Application.Common.PermissionType;
using Leadify.Domain.Constants;
using MediatR;

namespace Leadify.Application.Contacts.DeleteContactById;

[Authorize(Permissions = PermissionType.Contacts.Delete, Roles = RoleNames.SystemAdministrator)]
public sealed record DeleteContactByIdCommand(Ulid Id) : ICommand<Unit>;
