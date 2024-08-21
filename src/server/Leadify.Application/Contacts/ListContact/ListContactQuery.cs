using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Constants;
using Leadify.Domain.Entities;

namespace Leadify.Application.Contacts.ListContact;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public sealed record ListContactQuery() : IQuery<List<Contact>>;
