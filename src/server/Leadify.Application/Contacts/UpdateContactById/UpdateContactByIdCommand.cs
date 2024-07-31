using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;
using MediatR;

namespace Leadify.Application.Contacts.UpdateContactById;

public sealed record UpdateContactByIdCommand(Guid Id, Contact Contact) : ICommand<Unit>;
