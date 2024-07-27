using ErrorOr;
using Leadify.Domain.Entities;
using MediatR;

namespace Leadify.Application.Contacts.ListContact;

public sealed record ListContactQuery() : IRequest<ErrorOr<List<Contact>>>;
