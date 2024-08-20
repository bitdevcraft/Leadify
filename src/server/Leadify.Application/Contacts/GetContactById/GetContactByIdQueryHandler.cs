using Leadify.Application.Abstraction.Caching;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;

namespace Leadify.Application.Contacts.GetContactById;

internal sealed class GetContactByIdQueryHandler(IContactRepository contactRepository)
    : IQueryHandler<GetContactByIdQuery, Contact>
{
    private readonly IContactRepository _contactRepository = contactRepository;

    public async Task<Result<Contact>> Handle(
        GetContactByIdQuery request,
        CancellationToken cancellationToken
    )
    {
        Contact? contact = await _contactRepository.GetByIdAsync(request.Id, cancellationToken);

        if (contact is null)
        {
            return Result.Failure<Contact>(Error.NotFound());
        }

        return contact;
    }
}
