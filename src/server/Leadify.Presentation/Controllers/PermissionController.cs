using System.Collections;
using Leadify.Application.Abstraction.Authorization;
using Leadify.Application.Permissions.ListPermission;
using Leadify.Domain.Shared;
using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Controllers;

[Authorize]
public class PermissionController(ISender sender) : ApiController(sender)
{
    [HttpGet()]
    public async Task<IActionResult> GetPermissions()
    {
        var query = new ListPermissionQuery();
        Result<Hashtable> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }
}
