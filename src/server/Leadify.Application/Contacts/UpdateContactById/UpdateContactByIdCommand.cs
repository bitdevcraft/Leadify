using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Application.Common.PermissionType;
using Leadify.Domain.Constants;
using Leadify.Domain.Entities;
using MediatR;

namespace Leadify.Application.Contacts.UpdateContactById;

[Authorize(Permissions = PermissionType.Contacts.Edit, Roles = RoleNames.SystemAdministrator)]
public sealed record UpdateContactByIdCommand(Ulid Id, Contact Contact) : ICommand<Unit>;