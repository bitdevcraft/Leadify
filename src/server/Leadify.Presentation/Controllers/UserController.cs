using Leadify.Application.Users;
using Leadify.Application.Users.CreateUser;
using Leadify.Application.Users.ListUser;
using Leadify.Domain.Shared;
using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Controllers;

public class UserController(ISender sender) : ApiController(sender)
{
    [HttpPost("create")]
    public async Task<IActionResult> CreateNewUser([FromBody] UserDto user)
    {
        var query = new CreateUserCommand(user);
        Result<Unit> result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetUserList()
    {
        var query = new ListUserQuery();
        Result<List<UserListDto>> result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok(result.Value);
    }
}