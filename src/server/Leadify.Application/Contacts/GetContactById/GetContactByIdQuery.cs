using ErrorOr;
using Leadify.Domain.Entities;
using MediatR;

namespace Leadify.Application.Contacts.GetContactById;

public sealed record GetContactByIdQuery(Guid Id) : IRequest<ErrorOr<Contact>>;
