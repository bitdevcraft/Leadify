using System.Net;
using System.Text.Json;
using Leadify.Domain.Shared;

namespace Leadify.App.Middlewares;

public class ExceptionMiddleware(
    RequestDelegate next,
    ILogger<ExceptionMiddleware> logger,
    IHostEnvironment env
)
{
    private static readonly JsonSerializerOptions s_writeOptions =
        new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

    private readonly IHostEnvironment _env = env;
    private readonly ILogger<ExceptionMiddleware> _logger = logger;
    private readonly RequestDelegate _next = next;

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "{Message}", ex.Message);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            ServerError response = _env.IsDevelopment()
                ? new ServerError(
                    context.Response.StatusCode,
                    ex.Message,
                    ex.StackTrace
                )
                : new ServerError(context.Response.StatusCode, "Internal Server Error");

            string json = JsonSerializer.Serialize(response, s_writeOptions);

            await context.Response.WriteAsync(json);
        }
    }
}