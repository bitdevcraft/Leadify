using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Constants;
using Leadify.Domain.Entities;

namespace Leadify.Application.Contacts.ListContact;

[Authorize(Permissions = "Test", Roles = RoleNames.SystemAdministrator)]
public sealed record ListContactQuery() : IQuery<List<Contact>>;
