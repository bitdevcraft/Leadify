using Leadify.Application.Contacts.CreateContact;
using Leadify.Application.Contacts.DeleteContactById;
using Leadify.Application.Contacts.GetContactById;
using Leadify.Application.Contacts.ListContact;
using Leadify.Application.Contacts.UpdateContactById;
using Leadify.Domain.Entities;
using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Controllers;

public class ContactController : ApiController
{
    public ContactController(ISender sender)
        : base(sender) { }

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetContacts()
    {
        var query = new ListContactQuery();
        var result = await Sender.Send(query);

        if (result.IsFailure)
            return HandleFailure(result);
        return Ok(result.Value);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetContactById(String Id)
    {
        var query = new GetContactByIdQuery(Ulid.Parse(Id));
        var result = await Sender.Send(query);

        if (result.IsFailure)
            return HandleFailure(result);
        return Ok(result.Value);
    }

    [HttpPost()]
    public async Task<IActionResult> RegisterContact(Contact contact)
    {
        var query = new RegisterContactCommand(contact);
        var result = await Sender.Send(query);

        if (result.IsFailure)
            return HandleFailure(result);
        return Ok(result.Value);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateContact(String id, Contact contact)
    {
        var query = new UpdateContactByIdCommand(Ulid.Parse(id), contact);
        var result = await Sender.Send(query);

        if (result.IsFailure)
            return HandleFailure(result);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContact(String id)
    {
        var query = new DeleteContactByIdCommand(Ulid.Parse(id));
        var result = await Sender.Send(query);

        if (result.IsFailure)
            return HandleFailure(result);
        return Ok();
    }
}
