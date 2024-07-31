using Leadify.Domain.Users;

namespace Leadify.Application.Abstraction;

public interface IJwtProvider
{
    string Generate(User user);
}
