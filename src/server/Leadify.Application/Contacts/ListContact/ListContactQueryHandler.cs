using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;

namespace Leadify.Application.Contacts.ListContact;

public class ListContactQueryHandler(IContactRepository contactRepository)
    : IQueryHandler<ListContactQuery, List<Contact>>
{
    private readonly IContactRepository _contactRepository = contactRepository;

    public async Task<Result<List<Contact>>> Handle(
        ListContactQuery request,
        CancellationToken cancellationToken
    ) => await _contactRepository.GetAllContactAsync(cancellationToken);
}