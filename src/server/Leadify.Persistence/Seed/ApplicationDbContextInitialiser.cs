using Leadify.Domain.Constants;
using Leadify.Domain.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Leadify.Persistence.Seed;

public class ApplicationDbContextInitialiser(
    ILogger<ApplicationDbContextInitialiser> logger,
    ApplicationDbContext context,
    UserManager<User> userManager,
    RoleManager<Role> roleManager
)
{
    private readonly ApplicationDbContext _context = context;
    private readonly ILogger<ApplicationDbContextInitialiser> _logger = logger;
    private readonly RoleManager<Role> _roleManager = roleManager;
    private readonly UserManager<User> _userManager = userManager;

    public async Task InitialiseAsync()
    {
        try
        {
            await _context.Database.MigrateAsync();
        }
        catch (Exception ex)
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
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while seeding the database.");
            throw;
        }
    }

    public async Task TrySeedAsync()
    {
        // System Administrator
        // Default roles
        var sysAdminRole = new Role(RoleNames.SystemAdministrator);

        if (_roleManager.Roles.All(r => r.Name != sysAdminRole.Name))
        {
            await _roleManager.CreateAsync(sysAdminRole);
        }

        // Default users
        var sysAdmin = new User { UserName = "sysadmin@localhost", Email = "sysadmin@localhost" };

        if (_userManager.Users.All(u => u.UserName != sysAdmin.UserName))
        {
            await _userManager.CreateAsync(sysAdmin, "Administrator1!");
            if (!string.IsNullOrWhiteSpace(sysAdminRole.Name))
            {
                string[] roles = [sysAdminRole.Name];
                await _userManager.AddToRolesAsync(sysAdmin, roles);
            }
        }

        // Administrator
        // Default roles
        var adminRole = new Role(RoleNames.Administrator);

        if (_roleManager.Roles.All(r => r.Name != adminRole.Name))
        {
            await _roleManager.CreateAsync(adminRole);
        }

        // Default users
        var admin = new User { UserName = "admin@localhost", Email = "admin@localhost" };

        if (_userManager.Users.All(u => u.UserName != admin.UserName))
        {
            await _userManager.CreateAsync(admin, "Administrator1!");
            if (!string.IsNullOrWhiteSpace(adminRole.Name))
            {
                string[] roles = [adminRole.Name];
                await _userManager.AddToRolesAsync(admin, roles);
            }
        }
    }
}