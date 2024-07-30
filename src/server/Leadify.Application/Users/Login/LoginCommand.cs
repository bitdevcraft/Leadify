using ErrorOr;
using MediatR;

namespace Leadify.Application.Users.Login;

public sealed record LoginCommand(string Username, string Password)
    : IRequest<ErrorOr<LoginResponse>>;
