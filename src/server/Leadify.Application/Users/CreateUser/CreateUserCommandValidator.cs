using FluentValidation;

namespace Leadify.Application.Users.CreateUser;

internal sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.User.Email).EmailAddress().NotEmpty();
        RuleFor(x => x.User.UserName).NotEmpty();
        RuleFor(x => x.User.LastName).NotEmpty();
        RuleFor(x => x.User.Role).NotEmpty();
    }
}