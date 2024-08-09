using Leadify.Application.Abstraction.Messaging;
using MediatR;

namespace Leadify.Application.Contacts.DeleteContactById;

public sealed record DeleteContactByIdCommand(Ulid Id) : ICommand<Unit>;
