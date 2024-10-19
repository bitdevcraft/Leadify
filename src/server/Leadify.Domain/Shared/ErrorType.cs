namespace Leadify.Domain.Shared;

public enum ErrorType
{
    None,
    Failure,
    Unexpected,
    Validation,
    Conflict,
    NotFound,
    Unauthorized,
    Forbidden,
}
