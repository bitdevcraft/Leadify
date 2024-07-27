using ErrorOr;
using Leadify.Domain.Entities;
using MediatR;

namespace Leadify.Application.Contacts.UpdateContactById;

public sealed record UpdateContactByIdCommand(Guid Id, Contact Contact) : IRequest<ErrorOr<Unit>>;
