using Leadify.Application.Contacts.CreateContact;
using Leadify.Application.Contacts.DeleteContactById;
using Leadify.Application.Contacts.GetContactById;
using Leadify.Application.Contacts.ListContact;
using Leadify.Application.Contacts.UpdateContactById;
using Leadify.Domain.Entities;
using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leadify.Presentation.Controllers;

public class ContactController : ApiController
{
    public ContactController(ISender sender)
        : base(sender) { }

    [HttpGet()]
    public async Task<IActionResult> GetContacts()
    {
        var query = new ListContactQuery();
        var result = await Sender.Send(query);
        return result.Match(contacts => Ok(contacts), Problem);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetContactById(Guid Id)
    {
        var query = new GetContactByIdQuery(Id);
        var result = await Sender.Send(query);
        return result.Match(contact => Ok(contact), Problem);
    }

    [HttpPost()]
    public async Task<IActionResult> RegisterContact(Contact contact)
    {
        var query = new RegisterContactCommand(contact);
        var result = await Sender.Send(query);
        return result.Match(Id => Ok(Id), Problem);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateContact(Guid id, Contact contact)
    {
        var query = new UpdateContactByIdCommand(id, contact);
        var result = await Sender.Send(query);
        return result.Match(_ => Ok(), Problem);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContact(Guid id)
    {
        var query = new DeleteContactByIdCommand(id);
        var result = await Sender.Send(query);
        return result.Match(_ => Ok(), Problem);
    }
}
