namespace Leadify.Application.Abstraction.UserAccess;

public interface IUserContext
{
    Guid UserId { get; }
    string IdentityId { get; }
}
