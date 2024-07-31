using ErrorOr;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;
using Leadify.Domain.Repositories;
using MediatR;

namespace Leadify.Application.Contacts.CreateContact;

internal sealed class RegisterContactCommandHandler : ICommandHandler<RegisterContactCommand, Guid>
{
    private readonly IContactRepository _contactRepository;

    private readonly IUnitOfWork _unitOfWork;

    public RegisterContactCommandHandler(
        IContactRepository contactRepository,
        IUnitOfWork unitOfWork
    )
    {
        _unitOfWork = unitOfWork;
        _contactRepository = contactRepository;
    }

    public async Task<ErrorOr<Guid>> Handle(
        RegisterContactCommand request,
        CancellationToken cancellationToken
    )
    {
        var contact = Contact.Create(
            Guid.NewGuid(),
            request.Contact.Name,
            request.Contact.Email,
            request.Contact.Mobile,
            request.Contact.Phone
        );
        _contactRepository.Add(contact);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return contact.Id;
    }
}
