using System.Globalization;
using Leadify.Application.Contacts.CreateContact;
using Leadify.Application.Contacts.DeleteContactById;
using Leadify.Application.Contacts.GetContactById;
using Leadify.Application.Contacts.ListContact;
using Leadify.Application.Contacts.UpdateContactById;
using Leadify.Domain.Entities;
using Leadify.Domain.Shared;
using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Controllers;

public class ContactController(ISender sender) : ApiController(sender)
{
    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetContacts()
    {
        var query = new ListContactQuery();
        Result<List<Contact>> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetContactById(string Id)
    {
        var query = new GetContactByIdQuery(Ulid.Parse(Id));
        Result<Contact> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [HttpPost()]
    public async Task<IActionResult> RegisterContact(Contact contact)
    {
        var query = new RegisterContactCommand(contact);
        Result<Ulid> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateContact(string id, Contact contact)
    {
        var query = new UpdateContactByIdCommand(Ulid.Parse(id), contact);
        Result<Unit> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContact(string id)
    {
        var query = new DeleteContactByIdCommand(Ulid.Parse(id));
        Result<Unit> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok();
    }
}
