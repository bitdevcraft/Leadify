
namespace Leadify.Application.Abstraction.Authentication;

public interface IRefreshTokenProvider
{
    string GenerateRefreshToken();
}