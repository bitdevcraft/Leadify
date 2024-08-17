using System.Reflection;
using Leadify.Application.Abstraction.Authorization;
using Leadify.Domain.Shared;
using MediatR;

namespace Leadify.Application.Abstraction.Behaviors;

public class AuthorizationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IBaseRequest
    where TResponse : Result
{
    private readonly IAuthorizationService _authorizationService;

    public AuthorizationBehavior(IAuthorizationService authorizationService)
    {
        _authorizationService = authorizationService;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken
    )
    {
        var authorizationAttributes = request
            .GetType()
            .GetCustomAttributes<AuthorizeAttribute>()
            .ToList();

        if (authorizationAttributes.Count == 0)
        {
            return await next();
        }

        var requiredPermissions = authorizationAttributes
            .SelectMany(authorizationAttribute =>
                authorizationAttribute.Permissions?.Split(',') ?? []
            )
            .ToList();

        var requiredRoles = authorizationAttributes
            .SelectMany(authorizationAttribute => authorizationAttribute.Roles?.Split(',') ?? [])
            .ToList();

        var requiredPolicies = authorizationAttributes
            .SelectMany(authorizationAttribute => authorizationAttribute.Policies?.Split(',') ?? [])
            .ToList();

        var result = await _authorizationService.AuthorizeCurrentUser(
            requiredRoles,
            requiredPermissions,
            requiredPolicies
        );

        return result.IsSuccess ? await next() : CreateAuthResult<TResponse>();
    }

    private static TResult CreateAuthResult<TResult>()
        where TResult : Result
    {
        if (typeof(TResult) == typeof(Result))
        {
            return (Domain.Shared.Result.Failure(Error.Unauthorized()) as TResult)!;
        }

        object validationResult = typeof(Result<>)
            .GetGenericTypeDefinition()
            .MakeGenericType(typeof(TResult).GenericTypeArguments[0])
            .GetMethod(nameof(Domain.Shared.Result.Failure))!
            .Invoke(null, [Error.Unauthorized()])!;

        return (TResult)validationResult;
    }
}
