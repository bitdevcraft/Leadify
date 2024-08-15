using Leadify.Domain.Shared;
using Leadify.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Application.Users.Register;

internal sealed class RegisterCommandHandler(UserManager<User> userManager)
    : IRequestHandler<RegisterCommand, Result<Unit>>
{
    private readonly UserManager<User> _userManager = userManager;

    public async Task<Result<Unit>> Handle(
        RegisterCommand request,
        CancellationToken cancellationToken
    )
    {
        var exist = await _userManager.Users.AnyAsync(
            x => x.UserName == request.Username || x.Email == request.Email,
            cancellationToken: cancellationToken
        );

        if (exist)
            return Result.Failure<Unit>(Error.Validation(description: "Username/Email Taken"));

        var user = new User
        {
            Email = request.Email,
            UserName = request.Username
        };

        var result = await _userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
            return Result.Failure<Unit>(Error.Validation(description: "Problem registering User"));

        return Unit.Value;
    }
}
