using ErrorOr;
using Leadify.Domain.Repositories;
using MediatR;

namespace Leadify.Application.Contacts.DeleteContactById;

public class DeleteContactByIdCommandHandler
    : IRequestHandler<DeleteContactByIdCommand, ErrorOr<Unit>>
{
    private readonly IContactRepository _contactRepository;

    public DeleteContactByIdCommandHandler(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }

    public async Task<ErrorOr<Unit>> Handle(
        DeleteContactByIdCommand request,
        CancellationToken cancellationToken
    )
    {
        var result = await _contactRepository.GetByIdAsync(request.Id);

        if (result is null)
            return Error.NotFound();

        _contactRepository.Delete(result);

        return Unit.Value;
    }
}
