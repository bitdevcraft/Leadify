namespace Leadify.Domain.Shared;

public interface IValidationResult
{
    public static readonly Error ValidationError = Error.Validation();
    Error[] Errors { get; }
}
