using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;

namespace Leadify.Application.Contacts.CreateContact;

internal sealed class RegisterContactCommandHandler(
    IContactRepository contactRepository,
    IUnitOfWork unitOfWork
) : ICommandHandler<RegisterContactCommand, Ulid>
{
    private readonly IContactRepository _contactRepository = contactRepository;

    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result<Ulid>> Handle(
        RegisterContactCommand request,
        CancellationToken cancellationToken
    )
    {
        _contactRepository.Add(request.Contact);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return request.Contact.Id;
    }
}