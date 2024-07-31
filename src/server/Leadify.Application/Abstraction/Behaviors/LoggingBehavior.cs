﻿using ErrorOr;
using MediatR;
using Microsoft.Extensions.Logging;
using Serilog.Context;

namespace Leadify.Application.Abstraction.Behaviors;

public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IBaseRequest
    where TResponse : IErrorOr
{
    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;

    public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken
    )
    {
        var requestName = request.GetType().Name;

        try
        {
            _logger.LogInformation("Executing request {RequestName}", requestName);

            var result = await next();

            if (!result.IsError)
            {
                _logger.LogInformation("Request {RequestName} processed successfully", requestName);
            }
            else
            {
                using (LogContext.PushProperty("Error", result.Errors, true))
                {
                    _logger.LogError("Request {RequestName} processed with error", requestName);
                }
            }

            return result;
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Request {RequestName} processing failed", requestName);

            throw;
        }
    }
}
