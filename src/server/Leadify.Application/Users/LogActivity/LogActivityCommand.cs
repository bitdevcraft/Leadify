using Leadify.Domain.Shared;
using MediatR;

namespace Leadify.Application.Users.LogActivity;

public sealed record LogActivityCommand(string IpAddress, string DeviceInfo, string ActivityType)
    : IRequest<Result<Unit>>;