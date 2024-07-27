using ErrorOr;
using MediatR;

namespace Leadify.Application.Contacts.DeleteContactById;

public sealed record DeleteContactByIdCommand(Guid Id) : IRequest<ErrorOr<Unit>>;
