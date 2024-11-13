using AutoMapper;
using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;

namespace Leadify.Application.Users.ListUser;

public class ListUserQueryHandler(IUserRepository userRepository, IMapper mapper)
    : IQueryHandler<ListUserQuery, List<UserListDto>>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<List<UserListDto>>> Handle(ListUserQuery request, CancellationToken cancellationToken)
    {
        List<User> users = await _userRepository.GetUsers();

        List<UserListDto> userListDtos = _mapper.Map<List<User>, List<UserListDto>>(users);

        return userListDtos;
    }
}