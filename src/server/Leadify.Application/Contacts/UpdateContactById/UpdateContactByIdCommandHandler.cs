using AutoMapper;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Entities;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;
using MediatR;

namespace Leadify.Application.Contacts.UpdateContactById;

public class UpdateContactByIdCommandHandler(
    IContactRepository contactRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork
) : ICommandHandler<UpdateContactByIdCommand, Unit>
{
    private readonly IContactRepository _contactRepository = contactRepository;
    private readonly IMapper _mapper = mapper;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result<Unit>> Handle(
        UpdateContactByIdCommand request,
        CancellationToken cancellationToken
    )
    {
        Contact? contact = await _contactRepository.GetByIdAsync(request.Id, cancellationToken);

        if (contact == null)
        {
            return Result.Failure<Unit>(Error.NotFound());
        }

        _ = _mapper.Map(request.Contact, contact);

        bool result = await _unitOfWork.SaveChangesAsync(cancellationToken) > 0;

        if (!result)
        {
            return Result.Failure<Unit>(Error.Validation("Update Error"));
        }

        return Unit.Value;
    }
}