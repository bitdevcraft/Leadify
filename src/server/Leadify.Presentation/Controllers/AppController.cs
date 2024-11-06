using System.Text.Json;
using Leadify.Application.AppMenus.GetNgMenu;
using Leadify.Domain.ClientAppLayout;
using Leadify.Domain.Extensions;
using Leadify.Domain.Shared;
using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Controllers;

public class AppController(ISender sender) : ApiController(sender)
{
    [HttpGet("menu")]
    public async Task<IActionResult> GetContacts()
    {
        var query = new GetNgMenuQuery();
        Result<string> result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok(result.Value);
    }
}