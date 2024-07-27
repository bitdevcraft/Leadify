using ErrorOr;
using Leadify.Domain.Repositories;
using MediatR;

namespace Leadify.Application.Contacts.CreateContact;

internal sealed class RegisterContactCommandHandler
    : IRequestHandler<RegisterContactCommand, ErrorOr<Guid>>
{
    private readonly IContactRepository _contactRepository;

    public RegisterContactCommandHandler(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }

    public async Task<ErrorOr<Guid>> Handle(
        RegisterContactCommand request,
        CancellationToken cancellationToken
    )
    {
        var id = await _contactRepository.RegisterContactAsync(request.Contact, cancellationToken);
        return id;
    }
}
