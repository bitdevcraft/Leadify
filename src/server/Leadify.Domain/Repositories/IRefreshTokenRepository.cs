using Leadify.Domain.Users;

namespace Leadify.Domain.Repositories;

public interface IRefreshTokenRepository
{
    Task<RefreshToken?> GetRefreshToken(string refreshToken);
}