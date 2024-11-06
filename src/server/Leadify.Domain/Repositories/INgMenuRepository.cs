using System.Collections.ObjectModel;
using Leadify.Domain.ClientAppLayout;
using Leadify.Domain.Extensions;

namespace Leadify.Domain.Repositories;

public interface INgMenuRepository
{
    string GetRootNode();
}