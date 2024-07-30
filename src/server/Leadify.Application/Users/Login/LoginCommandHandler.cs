using ErrorOr;
using Leadify.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Leadify.Application.Users.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, ErrorOr<LoginResponse>>
{
    private readonly UserManager<User> _userManager;

    public LoginCommandHandler(UserManager<User> userManager)
    {
        _userManager = userManager;
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

        return new LoginResponse(request.Username, "");
    }
}
