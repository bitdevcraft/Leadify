using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;
using MediatR;

namespace Leadify.Application.Contacts.UpdateContactById;

public sealed record UpdateContactByIdCommand(Ulid Id, Contact Contact) : ICommand<Unit>;
