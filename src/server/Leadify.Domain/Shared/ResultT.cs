namespace Leadify.Domain.Shared;

public class Result<TValue>(TValue? value, bool isSuccess, Error error) : Result(isSuccess, error)
{
    private readonly TValue? _value = value;

    public TValue Value =>
        IsSuccess
            ? _value!
            : throw new InvalidOperationException(
                "The value of a failure result can not be accessed."
            );

    public static implicit operator Result<TValue>(TValue? value) => Create(value);

    public static new Result<TValue> Failure(Error error) => new(default, false, error);
}
