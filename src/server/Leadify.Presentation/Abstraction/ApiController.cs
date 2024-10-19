using Leadify.Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Abstraction;

[ApiController]
[Route("api/[controller]")]
public class ApiController : ControllerBase
{
    internal readonly ISender _sender;

    protected ApiController(ISender sender) => _sender = sender;

    protected IActionResult HandleFailure(Result result) =>
        result switch
        {
            { IsSuccess: true } => throw new InvalidOperationException(),
            IValidationResult validationResult
                => BadRequest(
                    CreateProblemDetails(
                        "Validation Error",
                        StatusCodes.Status400BadRequest,
                        result.Error,
                        validationResult.Errors
                    )
                ),
            { Error.Type: ErrorType.Conflict }
                => Conflict(
                    CreateProblemDetails("Conflict", StatusCodes.Status409Conflict, result.Error)
                ),
            { Error.Type: ErrorType.Validation }
                => BadRequest(
                    CreateProblemDetails(
                        "Bad Request",
                        StatusCodes.Status400BadRequest,
                        result.Error
                    )
                ),
            { Error.Type: ErrorType.NotFound }
                => NotFound(
                    CreateProblemDetails("Not Found", StatusCodes.Status404NotFound, result.Error)
                ),
            { Error.Type: ErrorType.Unauthorized }
                => Unauthorized(
                    CreateProblemDetails(
                        "Forbidden",
                        StatusCodes.Status401Unauthorized,
                        result.Error
                    )
                ),
            _
                => BadRequest(
                    CreateProblemDetails(
                        "Internal Server Error",
                        StatusCodes.Status500InternalServerError,
                        result.Error
                    )
                )
        };

    private static ProblemDetails CreateProblemDetails(
        string title,
        int status,
        Error error,
        Error[]? errors = null
    ) =>
        new()
        {
            Title = title,
            Type = error.Code,
            Detail = error.Description,
            Status = status,
            Extensions = { { nameof(errors), errors } }
        };
}
