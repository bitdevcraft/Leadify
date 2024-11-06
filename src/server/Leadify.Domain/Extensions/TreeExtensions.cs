#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace Leadify.Domain.Extensions;

public static class TreeExtensions
{
    /// <summary> Flatten tree to plain list of nodes </summary>
    public static IEnumerable<TNode> Flatten<TNode>(this IEnumerable<TNode> nodes,
        Func<TNode, IEnumerable<TNode>> childrenSelector)
    {
        ArgumentNullException.ThrowIfNull(nodes);
        return nodes.SelectMany(c => childrenSelector(c).Flatten(childrenSelector)).Concat(nodes);
    }

    /// <summary> Converts given list to tree. </summary>
    /// <typeparam name="T">Custom data type to associate with tree node.</typeparam>
    /// <param name="items">The collection items.</param>
    /// <param name="parentSelector">Expression to select parent.</param>
    public static ITree<T> ToTree<T>(this IList<T> items, Func<T, T, bool> parentSelector)
    {
        ArgumentNullException.ThrowIfNull(items);

        ILookup<T?, T> lookup = items.ToLookup(item => items.FirstOrDefault(parent => parentSelector(parent, item)),
            child => child);
        return Tree<T>.FromLookup(lookup!);
    }

    /// <summary> Internal implementation of <see cref="ITree{T}" /></summary>
    /// <typeparam name="T">Custom data type to associate with tree node.</typeparam>
    internal sealed class Tree<T> : ITree<T>
    {
        public T Data { get; }
        public ITree<T> Parent { get; private set; }
        public ICollection<ITree<T>> Children { get; }
        public bool IsRoot => null == Parent;
        public bool IsLeaf => Children.Count == 0;
        public int Level => IsRoot ? 0 : Parent.Level + 1;

        private Tree(T data)
        {
            Children = new LinkedList<ITree<T>>();
            Data = data;
        }

        public static Tree<T> FromLookup(ILookup<T, T> lookup)
        {
            T? rootData = lookup.Count == 1 ? lookup.First().Key : default;
            var root = new Tree<T>(rootData);
            root.LoadChildren(lookup);
            return root;
        }

        private void LoadChildren(ILookup<T, T> lookup)
        {
            foreach (T data in lookup[Data])
            {
                var child = new Tree<T>(data) { Parent = this };
                Children.Add(child);
                child.LoadChildren(lookup);
            }
        }
    }
}