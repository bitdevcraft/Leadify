﻿using Leadify.Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Leadify.Presentation.Abstraction;

[ApiController]
[Route("api/[controller]")]
public class ApiController : ControllerBase
{
    internal readonly ISender _sender;

    protected ApiController(ISender sender) => _sender = sender;

    /* protected ActionResult Problem(List<Error> errors)
     {
         if (errors.Count is 0)
         {
             return Problem();
         }

         if (errors.All(error => error.Type == ErrorType.Validation))
         {
             return ValidationProblem(errors);
         }

         return Problem(errors[0]);
     }

     private ObjectResult Problem(Error error)
     {
         var statusCode = error.Type switch
         {
             ErrorType.Conflict => StatusCodes.Status409Conflict,
             ErrorType.Validation => StatusCodes.Status400BadRequest,
             ErrorType.NotFound => StatusCodes.Status404NotFound,
             ErrorType.Unauthorized => StatusCodes.Status403Forbidden,
             _ => StatusCodes.Status500InternalServerError,
         };

         return Problem(statusCode: statusCode, title: error.Description);
     }
    

    private ActionResult ValidationProblem(List<Error> errors)
    {
        var modelStateDictionary = new ModelStateDictionary();

        errors.ForEach(error => modelStateDictionary.AddModelError(error.Code, error.Description));

        return ValidationProblem(modelStateDictionary);
    }
     */

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
                    CreateProblemDetails("Forbidden", StatusCodes.Status403Forbidden, result.Error)
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
