using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;

namespace Leadify.Application.Contacts.ListContact;

[Authorize(Policies = "Test")]
public sealed record ListContactQuery() : IQuery<List<Contact>>;
