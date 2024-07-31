using ErrorOr;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Repositories;
using MediatR;

namespace Leadify.Application.Contacts.DeleteContactById;

public class DeleteContactByIdCommandHandler : ICommandHandler<DeleteContactByIdCommand, Unit>
{
    private readonly IContactRepository _contactRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteContactByIdCommandHandler(
        IContactRepository contactRepository,
        IUnitOfWork unitOfWork
    )
    {
        _unitOfWork = unitOfWork;
        _contactRepository = contactRepository;
    }

    public async Task<ErrorOr<Unit>> Handle(
        DeleteContactByIdCommand request,
        CancellationToken cancellationToken
    )
    {
        var contact = await _contactRepository.GetByIdAsync(request.Id);

        if (contact is null)
            return Error.NotFound();

        _contactRepository.Delete(contact);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken) > 0;

        if (!result)
            return Error.Failure("Failed to Delete");

        return Unit.Value;
    }
}
