using System.Collections.ObjectModel;
using Leadify.Domain.Repositories;
using Leadify.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Persistence.Repositories;

public class UserRepository(ApplicationDbContext dbContext) : IUserRepository
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<List<User>> GetUsers() => await _dbContext.Set<User>()
        .Include(x => x.UserRoles)
        .ThenInclude(x => x.Role)
        .ToListAsync();
}