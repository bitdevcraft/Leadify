using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;

namespace Leadify.Application.Contacts.CreateContact;

public sealed record RegisterContactCommand(Contact Contact) : ICommand<Ulid>;
