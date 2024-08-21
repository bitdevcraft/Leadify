using Leadify.Domain.Repositories;
using Leadify.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Persistence.Repositories;

public class RoleRepository(
    ApplicationDbContext context,
    IPermissionRepository permissionRepository,
    IUnitOfWork unitOfWork
) : IRoleRepository
{
    private readonly ApplicationDbContext _context = context;
    private readonly IPermissionRepository _permissionRepository = permissionRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<int> AddToPermissionAsync(Role role, IEnumerable<string> permissionName)
    {
        List<string> rolePermissionExist = await _permissionRepository.GetAllByRoleIdAsync(
            role.Id.ToString()
        );

        IEnumerable<string> permissionSet = permissionName.Except(rolePermissionExist);

        var normalizePermission = new HashSet<string>();
        foreach (string permission in permissionSet)
        {
            normalizePermission.Add(permission.ToUpperInvariant());
        }

        List<Permission> permissions = await _context
            .Set<Permission>()
            .Where(x => normalizePermission.Contains(x.NormalizedName ?? ""))
            .ToListAsync();

        var rolePermissions = new List<RolePermission>();
        foreach (Permission item in permissions)
        {
            rolePermissions.Add(new RolePermission { Role = role, Permission = item });
        }

        await _context.AddRangeAsync(rolePermissions);

        return await _unitOfWork.SaveChangesAsync();
    }

    public async Task<int> AddUsersAsync(Role role, IEnumerable<string> userIds)
    {
        List<User> users = await _context
            .Set<User>()
            .Where(x => userIds.Contains(x.Id.ToString()))
            .ToListAsync();

        List<User> existingUsers = await _context
            .Set<UserRole>()
            .Where(x => x.RoleId == role.Id)
            .Select(x => x.User)
            .ToListAsync();

        var newUsers = users.Except(existingUsers).ToList();

        if (newUsers is null)
        {
            return 0;
        }

        var userRoles = new List<UserRole>();
        foreach (User? item in newUsers)
        {
            if (item is null)
            {
                continue;
            }

            userRoles.Add(new UserRole { Role = role, User = item });
        }

        await _context.AddRangeAsync(userRoles);

        return await _unitOfWork.SaveChangesAsync();
    }
}
