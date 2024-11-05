using Leadify.Domain.Users;

namespace Leadify.Domain.Repositories;

public interface IUserActivityRepository
{
    void AddUserActivity(UserActivity userActivity);
}