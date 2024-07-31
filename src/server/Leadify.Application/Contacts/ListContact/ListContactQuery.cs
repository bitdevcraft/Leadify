using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;

namespace Leadify.Application.Contacts.ListContact;

public sealed record ListContactQuery() : IQuery<List<Contact>>;
