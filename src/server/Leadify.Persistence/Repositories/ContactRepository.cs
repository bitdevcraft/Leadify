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

    public async Task<Contact?> GetByIdAsync(
        Guid Id,
        CancellationToken cancellationToken = default
    ) =>
        await _dbContext
            .Set<Contact>()
            .FirstOrDefaultAsync(contact => contact.Id == Id, cancellationToken);

    public void Add(Contact contact) => _dbContext.Set<Contact>().Add(contact);

    public void Delete(Contact contact) => _dbContext.Remove(contact);

    public void Update(Contact contact) => _dbContext.Set<Contact>().Update(contact);
}
