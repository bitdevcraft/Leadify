using Leadify.Application.Abstraction.UserAccess;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Leadify.Application.Users.LogActivity;

internal sealed class LogActivityCommandHandler(
    IUserActivityRepository userActivityRepository,
    IUnitOfWork unitOfWork,
    UserManager<User> userManager,
    IUserContext userContext)
    : IRequestHandler<LogActivityCommand, Result<Unit>>
{
    private readonly IUserActivityRepository _userActivityRepository = userActivityRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly UserManager<User> _userManager = userManager;
    private readonly IUserContext _userContext = userContext;

    public async Task<Result<Unit>> Handle(LogActivityCommand request, CancellationToken cancellationToken)
    {
        User? user = await _userManager.FindByIdAsync(_userContext.IdentityId);

        if (user is null)
        {
            return Result.Failure<Unit>(Error.Unauthorized());
        }

        var userActivity = new UserActivity
        {
            User = user,
            IpAddress = request.IpAddress,
            DeviceInfo = request.DeviceInfo,
            ActivityType = request.ActivityType
        };

        _userActivityRepository.AddUserActivity(userActivity);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}