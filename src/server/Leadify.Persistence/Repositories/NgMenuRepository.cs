using System.Text.Json;
using System.Text.Json.Serialization;
using Leadify.Domain.ClientAppLayout;
using Leadify.Domain.Extensions;
using Leadify.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Persistence.Repositories;

public class NgMenuRepository(ApplicationDbContext dbContext) : INgMenuRepository
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public string GetRootNode() => JsonSerializer.Serialize(GetMenuTree(), s_writeOptions);

    private static readonly JsonSerializerOptions s_writeOptions =
        new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            MaxDepth = 128,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

    private List<NgMenu>? GetMenuTree()
    {
        // Get all menus with their children
        var allMenus = _dbContext.Set<NgMenu>()
            .Include(menu => menu.Items)
            .OrderBy(x => x.Hierarchy)
            .ToList();

        // Build the menu tree
        List<NgMenu>? menuTree = BuildTree(allMenus, null);
        return menuTree;
    }

    private static List<NgMenu>? BuildTree(List<NgMenu> allMenus, Ulid? parentId)
    {
        var menus = allMenus
            .Where(menu => menu.ParentId == parentId)
            .OrderBy(menu => menu.Hierarchy)
            .Select(menu => new NgMenu
            {
                Id = menu.Id,
                Label = menu.Label,
                Icon = menu.Icon,
                RouterLinkArray = menu.RouterLinkArray,
                UrlArray = menu.UrlArray,
                Items = BuildTree(allMenus, menu.Id) // Recursive call to get children
            })
            .ToList();

        return menus.Count != 0 ? menus : null;
    }
}