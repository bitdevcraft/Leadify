using AutoMapper;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Application.Users.CreateUser;

internal sealed class CreateUserCommandHandler(
    UserManager<User> userManager,
    IMapper mapper)
    : IRequestHandler<CreateUserCommand, Result<Unit>>
{
    private readonly UserManager<User> _userManager = userManager;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<Unit>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        bool exist = await _userManager.Users.AnyAsync(
            x => x.UserName == request.User.UserName || x.Email == request.User.Email,
            cancellationToken: cancellationToken
        );

        if (exist)
        {
            return Result.Failure<Unit>(Error.Validation(description: "Username/Email Taken"));
        }

        if (request.User.Role is null)
        {
            return Result.Failure<Unit>(Error.Validation(description: "Role Required"));
        }

        var user = new User();

        _mapper.Map(request.User, user);


        IdentityResult result = await _userManager.CreateAsync(user, "UserPW123!");

        if (!result.Succeeded)
        {
            return Result.Failure<Unit>(Error.Validation(description: "Problem registering User"));
        }

        result = await _userManager.AddToRoleAsync(user, request.User.Role);

        if (result.Succeeded)
        {
            return Unit.Value;
        }

        await _userManager.DeleteAsync(user);
        return Result.Failure<Unit>(Error.Validation(description: "Problem registering User"));
    }
}