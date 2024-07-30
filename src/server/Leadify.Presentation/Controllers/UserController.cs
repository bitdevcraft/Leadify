using Leadify.Application.Users.Login;
using Leadify.Application.Users.Register;
using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Controllers;

public class UserController : ApiController
{
    public UserController(ISender sender)
        : base(sender) { }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        var query = new RegisterCommand(request.Email, request.Username, request.Password);
        var result = await Sender.Send(query);

        return result.Match(_ => Ok(), Problem);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var query = new LoginCommand(request.Username, request.Password);
        var result = await Sender.Send(query);

        return result.Match(resp => Ok(resp), Problem);
    }
}
