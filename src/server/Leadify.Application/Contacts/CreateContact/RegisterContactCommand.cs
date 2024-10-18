using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Application.Common.PermissionType;
using Leadify.Domain.Constants;
using Leadify.Domain.Entities;

namespace Leadify.Application.Contacts.CreateContact;

[Authorize(Permissions = PermissionType.Contacts.Create, Roles = RoleNames.SystemAdministrator)]
public sealed record RegisterContactCommand(Contact Contact) : ICommand<Ulid>;