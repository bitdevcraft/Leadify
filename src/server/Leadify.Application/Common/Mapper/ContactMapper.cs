using AutoMapper;
using Leadify.Domain.Entities;

namespace Leadify.Application.Common.Mapper;

public class ContactMapper : Profile
{
    public ContactMapper()
    {
        CreateMap<Contact, Contact>()
            .ForMember(x => x.Id, opt => opt.Ignore())
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
    }
}
