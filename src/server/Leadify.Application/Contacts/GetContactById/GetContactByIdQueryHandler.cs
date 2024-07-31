using ErrorOr;
using Leadify.Application.Abstraction.Caching;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;
using Leadify.Domain.Repositories;
using MediatR;

namespace Leadify.Application.Contacts.GetContactById;

internal sealed class GetContactByIdQueryHandler : IQueryHandler<GetContactByIdQuery, Contact>
{
    private readonly IContactRepository _contactRepository;
    private readonly ICacheService _cacheService;

    public GetContactByIdQueryHandler(
        IContactRepository contactRepository,
        ICacheService cacheService
    )
    {
        _contactRepository = contactRepository;
        _cacheService = cacheService;
    }

    public async Task<ErrorOr<Contact>> Handle(
        GetContactByIdQuery request,
        CancellationToken cancellationToken
    )
    {
        var contact = await _cacheService.GetAsync<Contact>(request.CacheKey);

        if (contact is not null)
            return contact;

        contact = await _contactRepository.GetByIdAsync(request.Id, cancellationToken);

        if (contact is null)
            return Error.NotFound();

        await _cacheService.SetAsync<Contact>(
            request.CacheKey,
            contact,
            request.Expiration,
            cancellationToken
        );

        return contact;
    }
}
