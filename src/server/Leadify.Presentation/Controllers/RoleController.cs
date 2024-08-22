using Leadify.Application.Roles.AssignPermission;
using Leadify.Application.Roles.AssignUsers;
using Leadify.Application.Roles.CreateRole;
using Leadify.Application.Roles.DeleteRole;
using Leadify.Application.Roles.ListRole;
using Leadify.Domain.Shared;
using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Controllers;

[Authorize]
public class RoleController(ISender sender) : ApiController(sender)
{
    [HttpGet()]
    public async Task<IActionResult> GetRoles()
    {
        var query = new ListRoleQuery();
        Result<List<string?>> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [HttpPost()]
    public async Task<IActionResult> CreateRole(string RoleName)
    {
        var query = new CreateRoleCommand(RoleName);
        Result result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok();
    }

    [HttpDelete()]
    public async Task<IActionResult> DeleteRole(string RoleName)
    {
        var query = new DeleteRoleCommand(RoleName);
        Result result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok();
    }

    [HttpPost("permissions")]
    public async Task<IActionResult> AssignPermissions(
        string RoleName,
        IEnumerable<string> PermissionNames
    )
    {
        var query = new AssignPermissionCommand(RoleName, PermissionNames);
        Result result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok();
    }

    [HttpPost("users")]
    public async Task<IActionResult> AssignUsers(string RoleName, IEnumerable<string> UserIds)
    {
        var query = new AssignUsersCommand(RoleName, UserIds);
        Result result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok();
    }
}
