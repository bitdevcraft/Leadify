using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leadify.Domain.Users;

namespace Leadify.Domain.Repositories;

public interface IRoleRepository
{
    Task<int> AddToPermissionAsync(Role role, IEnumerable<string> permissionName);
}
