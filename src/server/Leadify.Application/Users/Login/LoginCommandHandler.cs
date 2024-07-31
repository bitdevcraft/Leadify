using ErrorOr;
using Leadify.Application.Abstraction;
using Leadify.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Leadify.Application.Users.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, ErrorOr<LoginResponse>>
{
    private readonly UserManager<User> _userManager;
    private readonly IJwtProvider _jwtProvider;

    public LoginCommandHandler(UserManager<User> userManager, IJwtProvider jwtProvider)
    {
        _userManager = userManager;
        _jwtProvider = jwtProvider;
    }

    public async Task<ErrorOr<LoginResponse>> Handle(
        LoginCommand request,
        CancellationToken cancellationToken
    )
    {
        var user = await _userManager.FindByNameAsync(request.Username);

        if (user == null)
            return Error.Unauthorized();

        var result = await _userManager.CheckPasswordAsync(user, request.Password);

        if (!result)
            return Error.Unauthorized();

        var token = _jwtProvider.Generate(user);

        return new LoginResponse(request.Username, token);
    }
}
