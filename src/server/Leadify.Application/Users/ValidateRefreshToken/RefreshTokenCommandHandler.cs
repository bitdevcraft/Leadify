using Leadify.Application.Abstraction.Authentication;
using Leadify.Application.Users.Login;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Leadify.Application.Users.ValidateRefreshToken;

public class RefreshTokenCommandHandler(
    IRefreshTokenRepository refreshTokenRepository,
    UserManager<User> userManager,
    IRefreshTokenProvider refreshTokenProvider,
    IJwtProvider jwtProvider)
    : IRequestHandler<RefreshTokenCommand, Result<LoginResponse>>
{
    private readonly IRefreshTokenRepository _refreshTokenRepository = refreshTokenRepository;
    private readonly UserManager<User> _userManager = userManager;
    private readonly IRefreshTokenProvider _refreshTokenProvider = refreshTokenProvider;
    private readonly IJwtProvider _jwtProvider = jwtProvider;

    public async Task<Result<LoginResponse>> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
    {
        RefreshToken? refreshToken = await _refreshTokenRepository.GetRefreshToken(request.RefreshToken);

        if (refreshToken is null)
        {
            return Result.Failure<LoginResponse>(Error.Unauthorized());
        }

        if (refreshToken.User.UserName is null)
        {
            return Result.Failure<LoginResponse>(Error.Unauthorized());
        }

        string newRefreshToken = _refreshTokenProvider.GenerateRefreshToken();
        string token = _jwtProvider.Generate(refreshToken.User);

        refreshToken.User.RefreshTokens.Add(new RefreshToken
            { User = refreshToken.User, Token = newRefreshToken });

        await _userManager.UpdateAsync(refreshToken.User);

        return new LoginResponse(refreshToken.User.UserName, token, newRefreshToken);
    }
}