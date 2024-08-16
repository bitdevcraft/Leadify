﻿using Leadify.Domain.Constants;
using Leadify.Domain.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Leadify.Persistence.Seed;

public class ApplicationDbContextInitialiser
{
    private readonly ILogger<ApplicationDbContextInitialiser> _logger;
    private readonly ApplicationDbContext _context;
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<Role> _roleManager;

    public ApplicationDbContextInitialiser(
        ILogger<ApplicationDbContextInitialiser> logger,
        ApplicationDbContext context,
        UserManager<User> userManager,
        RoleManager<Role> roleManager
    )
    {
        _context = context;
        _userManager = userManager;

        _roleManager = roleManager;
        _logger = logger;
    }

    public async Task InitialiseAsync()
    {
        try
        {
            await _context.Database.MigrateAsync();
        }
        catch (System.Exception ex)
        {
            _logger.LogError(ex, "An error occurred while initialising the database.");
            throw;
        }
    }

    public async Task SeedAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (System.Exception ex)
        {
            _logger.LogError(ex, "An error occurred while seeding the database.");
            throw;
        }
    }

    public async Task TrySeedAsync()
    {
        // Default roles
        var sysAdminRole = new Role(RoleNames.SystemAdministrator);

        if (_roleManager.Roles.All(r => r.Name != sysAdminRole.Name))
        {
            await _roleManager.CreateAsync(sysAdminRole);
        }

        // Default users
        var administrator = new User
        {
            UserName = "sysadmin@localhost",
            Email = "sysadmin@localhost"
        };

        if (_userManager.Users.All(u => u.UserName != administrator.UserName))
        {
            await _userManager.CreateAsync(administrator, "Administrator1!");
            if (!string.IsNullOrWhiteSpace(sysAdminRole.Name))
            {
                await _userManager.AddToRolesAsync(administrator, new[] { sysAdminRole.Name });
            }
        }
    }
}
