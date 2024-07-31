using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;

namespace Leadify.Application.Contacts.GetContactById;

public sealed record GetContactByIdQuery(Guid Id) : IQuery<Contact>;
