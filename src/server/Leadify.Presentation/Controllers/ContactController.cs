using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Controllers;

public class ContactController : ApiController
{
    public ContactController(ISender sender)
        : base(sender) { }

    [HttpGet()]
    public IActionResult GetContacts()
    {
        return Ok();
    }
}
