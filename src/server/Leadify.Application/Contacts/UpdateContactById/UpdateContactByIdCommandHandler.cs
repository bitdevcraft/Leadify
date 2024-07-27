using AutoMapper;
using ErrorOr;
using Leadify.Domain.Entities;
using Leadify.Domain.Repositories;
using MediatR;

namespace Leadify.Application.Contacts.UpdateContactById;

public class UpdateContactByIdCommandHandler
    : IRequestHandler<UpdateContactByIdCommand, ErrorOr<Unit>>
{
    private readonly IContactRepository _contactRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateContactByIdCommandHandler(
        IContactRepository contactRepository,
        IMapper mapper,
        IUnitOfWork unitOfWork
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _contactRepository = contactRepository;
    }

    public async Task<ErrorOr<Unit>> Handle(
        UpdateContactByIdCommand request,
        CancellationToken cancellationToken
    )
    {
        var contact = await _contactRepository.GetByIdAsync(request.Id, cancellationToken);

        if (contact == null)
            return Error.NotFound();

        _mapper.Map(request.Contact, contact);

        var result = await _unitOfWork.SaveChangesAsync(cancellationToken) > 0;

        if (!result)
            return Error.Failure("Update Failed");

        return Unit.Value;
    }
}
