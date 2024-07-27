using ErrorOr;
using Leadify.Domain.Entities;
using Leadify.Domain.Repositories;
using MediatR;

namespace Leadify.Application.Contacts.ListContact;

public class ListContactQueryHandler : IRequestHandler<ListContactQuery, ErrorOr<List<Contact>>>
{
    private readonly IContactRepository _contactRepository;

    public ListContactQueryHandler(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }

    public async Task<ErrorOr<List<Contact>>> Handle(
        ListContactQuery request,
        CancellationToken cancellationToken
    )
    {
        return await _contactRepository.GetAllContactAsync(cancellationToken);
    }
}
