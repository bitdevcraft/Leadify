using Leadify.Application.Users.Login;
using Leadify.Domain.Shared;
using MediatR;

namespace Leadify.Application.Users.ValidateRefreshToken;

public record RefreshTokenCommand(string RefreshToken) : IRequest<Result<LoginResponse>>;