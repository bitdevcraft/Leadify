using ErrorOr;
using Leadify.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Application.Users.Register;

internal sealed class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<Unit>>
{
    private readonly UserManager<User> _userManager;

    public RegisterCommandHandler(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public async Task<ErrorOr<Unit>> Handle(
        RegisterCommand request,
        CancellationToken cancellationToken
    )
    {
        var exist = await _userManager.Users.AnyAsync(x =>
            x.UserName == request.Username || x.Email == request.Email
        );

        if (exist)
            return Error.Validation(description: "Username/Email Taken");

        var user = new User { Email = request.Email, UserName = request.Username };

        var result = await _userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
            return Error.Validation(description: "Problem registering user");

        return Unit.Value;
    }
}
