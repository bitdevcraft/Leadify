using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;
using MediatR;

namespace Leadify.Application.Contacts.DeleteContactById;

public class DeleteContactByIdCommandHandler(
    IContactRepository contactRepository,
    IUnitOfWork unitOfWork
) : ICommandHandler<DeleteContactByIdCommand, Unit>
{
    private readonly IContactRepository _contactRepository = contactRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result<Unit>> Handle(
        DeleteContactByIdCommand request,
        CancellationToken cancellationToken
    )
    {
        Contact? contact = await _contactRepository.GetByIdAsync(request.Id, cancellationToken);

        if (contact is null)
        {
            return Result.Failure<Unit>(Error.NotFound());
        }

        _contactRepository.Delete(contact);
        bool result = await _unitOfWork.SaveChangesAsync(cancellationToken) > 0;

        if (!result)
        {
            return Result.Failure<Unit>(Error.Validation("Failure to Delete"));
        }

        return Unit.Value;
    }
}
