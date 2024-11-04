using Leadify.Domain.Users;

namespace Leadify.Application.Abstraction.Authentication;

public interface IRefreshTokenProvider
{
    string GenerateRefreshToken();
}