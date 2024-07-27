using ErrorOr;
using Leadify.Domain.Entities;
using MediatR;

namespace Leadify.Application.Contacts.CreateContact;

public sealed record RegisterContactCommand(Contact Contact) : IRequest<ErrorOr<Guid>>;
