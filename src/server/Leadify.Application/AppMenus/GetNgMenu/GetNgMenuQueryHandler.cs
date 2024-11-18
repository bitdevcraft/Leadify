using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;

namespace Leadify.Application.AppMenus.GetNgMenu;

public class GetNgMenuQueryHandler(INgMenuRepository ngMenuRepository) : IQueryHandler<GetNgMenuQuery, string>
{
    private readonly INgMenuRepository _ngMenuRepository = ngMenuRepository;

    public Task<Result<string>> Handle(GetNgMenuQuery request, CancellationToken cancellationToken) =>
        Task.FromResult(Result.Create(_ngMenuRepository.GetRootNode()));
}