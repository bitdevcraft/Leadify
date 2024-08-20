using Leadify.Application.Abstraction.Authentication;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Leadify.Application.Users.Login;

public class LoginCommandHandler(UserManager<User> userManager, IJwtProvider jwtProvider)
    : IRequestHandler<LoginCommand, Result<LoginResponse>>
{
    private readonly UserManager<User> _userManager = userManager;
    private readonly IJwtProvider _jwtProvider = jwtProvider;

    public async Task<Result<LoginResponse>> Handle(
        LoginCommand request,
        CancellationToken cancellationToken
    )
    {
        var user = await _userManager.FindByNameAsync(request.Username);

        if (user == null)
            return Result.Failure<LoginResponse>(Error.Unauthorized());

        var result = await _userManager.CheckPasswordAsync(user, request.Password);

        if (!result)
            return Result.Failure<LoginResponse>(Error.Unauthorized());

        var token = _jwtProvider.Generate(user);

        return new LoginResponse(request.Username, token);
    }
}
