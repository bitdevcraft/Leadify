using Leadify.Domain.Entities;

namespace Leadify.Domain.Repositories;

public interface IContactRepository
{
    Task<List<Contact>> GetAllContactAsync(CancellationToken cancellationToken = default);
    Task<Contact?> GetContactByIdAsync(Guid Id, CancellationToken cancellationToken = default);
    Task<Guid> RegisterContactAsync(Contact contact, CancellationToken cancellationToken = default);
    Task<Contact?> UpdateContactById(
        Guid Id,
        Contact contact,
        CancellationToken cancellationToken = default
    );
}
