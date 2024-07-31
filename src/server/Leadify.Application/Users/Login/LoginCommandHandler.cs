using ErrorOr;
using Leadify.Application.Abstraction.Authentication;
using Leadify.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Leadify.Application.Users.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, ErrorOr<LoginResponse>>
{
    private readonly UserManager<User> _userManager;
    private readonly IJwtProvider _jwtProvider;
    private readonly ISessionProvider _sessionProvider;

    public LoginCommandHandler(
        UserManager<User> userManager,
        IJwtProvider jwtProvider,
        ISessionProvider sessionProvider
    )
    {
        _userManager = userManager;
        _jwtProvider = jwtProvider;
        _sessionProvider = sessionProvider;
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

        var sessionToken = _sessionProvider.Generate();

        return new LoginResponse(request.Username, token);
    }
}
