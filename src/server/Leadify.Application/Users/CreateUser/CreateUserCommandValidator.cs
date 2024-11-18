using FluentValidation;

namespace Leadify.Application.Users.CreateUser;

/// <summary>
/// 
/// </summary>
internal sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    /// <summary>
    /// 
    /// </summary>
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.User.Email).EmailAddress().NotEmpty();
        RuleFor(x => x.User.UserName).NotEmpty();
        RuleFor(x => x.User.LastName).NotEmpty();
        RuleFor(x => x.User.Role).NotEmpty();
    }
}