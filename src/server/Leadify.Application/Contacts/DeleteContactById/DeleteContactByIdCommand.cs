using Leadify.Application.Abstraction.Messaging;
using MediatR;

namespace Leadify.Application.Contacts.DeleteContactById;

public sealed record DeleteContactByIdCommand(Guid Id) : ICommand<Unit>;
