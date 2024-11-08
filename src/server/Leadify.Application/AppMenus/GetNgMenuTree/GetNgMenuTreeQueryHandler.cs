using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;

namespace Leadify.Application.AppMenus.GetNgMenuTree;

public class GetNgMenuTreeQueryHandler(INgMenuRepository ngMenuRepository) : IQueryHandler<GetNgMenuTreeQuery, string>
{
    private readonly INgMenuRepository _ngMenuRepository = ngMenuRepository;

    public Task<Result<string>> Handle(GetNgMenuTreeQuery request, CancellationToken cancellationToken) =>
        Task.FromResult(Result.Create(_ngMenuRepository.GetTreeNode()));
}