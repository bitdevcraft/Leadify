using Leadify.Domain.Users;

namespace Leadify.Application.Abstraction.Authentication;

public interface IJwtProvider
{
    string Generate(User user);
}
