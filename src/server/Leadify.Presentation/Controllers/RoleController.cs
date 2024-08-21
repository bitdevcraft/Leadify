using Leadify.Application.Roles.ListRole;
using Leadify.Domain.Shared;
using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Controllers;

public class RoleController(ISender sender) : ApiController(sender)
{
    //
    [HttpGet()]
    public async Task<IActionResult> GetContacts()
    {
        var query = new ListRoleQuery();
        Result<List<string?>> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }
}
