using ErrorOr;
using MediatR;

namespace Leadify.Application.Users.Register;

public sealed record RegisterCommand(string Email, string Username, string Password)
    : IRequest<ErrorOr<Unit>>;
