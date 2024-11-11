using System.Collections.ObjectModel;
using Leadify.Domain.ClientAppLayout;
using Leadify.Domain.Extensions;

namespace Leadify.Domain.Repositories;

public interface INgMenuRepository
{
    string GetRootNode();
    string GetTreeNode();
    void Add(NgMenu menu);
    void Delete(NgMenu menu);
    void Update(NgMenu menu);
    Task<NgMenu?> GetByIdAsync(Ulid? id, CancellationToken cancellationToken);
}