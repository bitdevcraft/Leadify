using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Application.Roles.ListRole;

internal sealed class ListRoleQueryHandler(RoleManager<Role> roleManager)
    : IQueryHandler<ListRoleQuery, List<string?>>
{
    private readonly RoleManager<Role> _roleManager = roleManager;

    public async Task<Result<List<string?>>> Handle(
        ListRoleQuery request,
        CancellationToken cancellationToken
    ) => await _roleManager.Roles.Select(x => x.Name).ToListAsync(cancellationToken);
}