using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using Leadify.Domain.Extensions;

namespace Leadify.Infrastructure.Extensions;

[SuppressMessage("Performance", "CA1822:Mark members as static")]
internal sealed class TreeUtils : ITreeUtils
{
    public Collection<T> GetParents<T>(ITree<T> node, Collection<T> parentNodes) where T : class
    {
        while (true)
        {
            if (node?.Parent?.Data == null)
            {
                return parentNodes;
            }

            parentNodes.Add(node.Parent.Data);
            node = node.Parent;
        }
    }
}