using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Abstraction;

[ApiController]
[Route("api/[controller]")]
public class ApiController : ControllerBase
{
    protected readonly ISender Sender;

    protected ApiController(ISender sender) => Sender = sender;
}
