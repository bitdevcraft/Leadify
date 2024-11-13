using Leadify.Domain.Users;

namespace Leadify.Domain.Repositories;

public interface IUserRepository
{
    Task<List<User>> GetUsers();
}