namespace Leadify.Domain.Primitives;

public abstract class Entity
{
    protected Entity(Ulid id) => Id = id;

    protected Entity() { }

    public Ulid Id { get; private init; }
}
