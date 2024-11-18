namespace Leadify.Domain.Primitives;

public abstract class Entity
{
    protected Entity() { }

    public Ulid Id { get; private init; } = Ulid.NewUlid();
}