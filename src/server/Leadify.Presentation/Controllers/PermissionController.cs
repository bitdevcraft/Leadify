﻿using Leadify.Application.Permissions.ListPermission;
using Leadify.Domain.Shared;
using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Controllers;

public class PermissionController(ISender sender) : ApiController(sender)
{
    [HttpGet()]
    public async Task<IActionResult> GetContacts()
    {
        var query = new ListPermissionQuery();
        Result<List<string>> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }
}
