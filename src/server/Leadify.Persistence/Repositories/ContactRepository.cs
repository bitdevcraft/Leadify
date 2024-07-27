using Leadify.Domain.Entities;
using Leadify.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Persistence.Repositories;

public class ContactRepository : IContactRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ContactRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Contact>> GetAllContactAsync(
        CancellationToken cancellationToken = default
    ) => await _dbContext.Set<Contact>().ToListAsync(cancellationToken);

    public async Task<Contact?> GetContactByIdAsync(
        Guid Id,
        CancellationToken cancellationToken = default
    ) =>
        await _dbContext
            .Set<Contact>()
            .Where(contact => contact.Id == Id)
            .FirstOrDefaultAsync(cancellationToken);

    public async Task<Guid> RegisterContactAsync(
        Contact contact,
        CancellationToken cancellationToken = default
    )
    {
        await _dbContext.Set<Contact>().AddAsync(contact);
        await _dbContext.SaveChangesAsync();
        return contact.Id;
    }

    public Task<Contact?> UpdateContactById(
        Guid Id,
        Contact contact,
        CancellationToken cancellationToken = default
    )
    {
        throw new NotImplementedException();
    }
}
