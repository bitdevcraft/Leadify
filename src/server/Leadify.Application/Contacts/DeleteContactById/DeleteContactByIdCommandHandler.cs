using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;
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

    public async Task<Result<Unit>> Handle(
        DeleteContactByIdCommand request,
        CancellationToken cancellationToken
    )
    {
        var contact = await _contactRepository.GetByIdAsync(request.Id, cancellationToken);

        if (contact is null)
            return Result.Failure<Unit>(Error.NotFound());

        _contactRepository.Delete(contact);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken) > 0;

        if (!result)
            return Result.Failure<Unit>(Error.Failure("Failure to Delete"));

        return Unit.Value;
    }
}
