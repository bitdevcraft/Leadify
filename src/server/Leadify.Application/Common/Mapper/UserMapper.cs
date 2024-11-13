using AutoMapper;
using Leadify.Application.Users;
using Leadify.Domain.Users;

namespace Leadify.Application.Common.Mapper;

public class UserMapper : Profile
{
    public UserMapper()
    {
        CreateMap<UserDto, User>()
            .ForMember(x => x.Id, opt => opt.Ignore())
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        CreateMap<User, UserListDto>()
            .ForMember(d => d.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}".Trim()))
            .ForMember(d => d.Role, opt => opt.MapFrom(src => src.UserRoles.Select(x => x.Role.Name).FirstOrDefault()))
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
    }
}