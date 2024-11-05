using Leadify.Domain.Repositories;
using Leadify.Domain.Users;

namespace Leadify.Persistence.Repositories;

public class UserActivityRepository(ApplicationDbContext dbContext) : IUserActivityRepository
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public void AddUserActivity(UserActivity userActivity) =>
        _dbContext.Set<UserActivity>().Add(userActivity);
}