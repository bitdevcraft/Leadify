using ErrorOr;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;
using Leadify.Domain.Repositories;
using MediatR;

namespace Leadify.Application.Contacts.GetContactById;

internal sealed class GetContactByIdQueryHandler : IQueryHandler<GetContactByIdQuery, Contact>
{
    private readonly IContactRepository _contactRepository;

    public GetContactByIdQueryHandler(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }

    public async Task<ErrorOr<Contact>> Handle(
        GetContactByIdQuery request,
        CancellationToken cancellationToken
    )
    {
        var result = await _contactRepository.GetByIdAsync(request.Id, cancellationToken);

        if (result == null)
            return Error.NotFound();

        return result;
    }
}
