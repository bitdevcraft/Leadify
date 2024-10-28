using Leadify.Application.Users.Login;
using Leadify.Application.Users.Register;
using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Controllers;

public class AuthController(ISender sender) : ApiController(sender)
{
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        var query = new RegisterCommand(request.Email, request.Username, request.Password);
        Domain.Shared.Result<Unit> result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var query = new LoginCommand(request.Username, request.Password);
        Domain.Shared.Result<LoginResponse> result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok(result.Value);
    }
}
