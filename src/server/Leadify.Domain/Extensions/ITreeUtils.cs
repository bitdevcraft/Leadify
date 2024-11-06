using System.Collections.ObjectModel;

namespace Leadify.Domain.Extensions;

public interface ITreeUtils
{
    Collection<T> GetParents<T>(ITree<T> node) where T : class => GetParents<T>(node, []);
    Collection<T> GetParents<T>(ITree<T> node, Collection<T> parentNodes) where T : class;
}