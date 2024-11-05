using Leadify.Domain.Repositories;
using Leadify.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Persistence.Repositories;

public class RefreshTokenRepository(ApplicationDbContext dbContext) : IRefreshTokenRepository
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<RefreshToken?> GetRefreshToken(string refreshToken)
        => await _dbContext.Set<RefreshToken>()
            .Where(rt => rt.Token == refreshToken
                         && rt.IsUsed == false)
            .Include(u => u.User)
            .FirstOrDefaultAsync();
}