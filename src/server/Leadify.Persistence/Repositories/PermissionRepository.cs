﻿using Leadify.Domain.Repositories;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Leadify.Persistence.Repositories;

public class PermissionRepository : IPermissionRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IUnitOfWork _unitOfWork;
    private readonly INormalizer _normalizer;

    public PermissionRepository(
        ApplicationDbContext context,
        IUnitOfWork unitOfWork,
        INormalizer normalizer
    )
    {
        _context = context;
        _unitOfWork = unitOfWork;
        _normalizer = normalizer;
    }

    public async Task<int> CreateAsync(string name)
    {
        var permission = new Permission(name) { NormalizedName = _normalizer.NormalizeName(name) };
        _context.Set<Permission>().Add(permission);

        return await _unitOfWork.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync(Permission permission)
    {
        _context.Set<Permission>().Remove(permission);
        return await _unitOfWork.SaveChangesAsync();
    }

    public async Task<Permission?> FindByNameAsync(string name)
    {
        return await _context
            .Set<Permission>()
            .FirstOrDefaultAsync(x => x.NormalizedName == _normalizer.NormalizeName(name));
    }

    public Task<List<string>> GetAllByRoleIdAsync(string Id)
    {
        return Task.FromResult(
            _context
                .Set<RolePermission>()
                .Where(x => x.RoleId == Ulid.Parse(Id))
                .Select(x => x.Permission.ToString())
                .ToList()
        );
    }

    public async Task<HashSet<string>> GetAllByUserIdAsync(string Id)
    {
        var userRoles = await _context
            .Set<UserRole>()
            .Where(x => x.UserId == Ulid.Parse(Id))
            .Select(x => x.Role.Id)
            .ToArrayAsync();

        if (userRoles.Length == 0)
            return [];

        var permissions = await _context
            .Set<RolePermission>()
            .Where(x => userRoles.Contains(x.RoleId))
            .Select(x => x.Permission.ToString())
            .ToListAsync();

        return [.. permissions];
    }
}