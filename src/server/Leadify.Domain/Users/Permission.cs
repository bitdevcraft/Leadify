namespace Leadify.Domain.Users;

public class Permission : Permission<Ulid>
{
    public Permission()
    {
        Id = Ulid.NewUlid();
    }

    public Permission(string permissionName)
        : this()
    {
        Name = permissionName;
    }

    public virtual ICollection<RolePermission>? RolePermissions { get; set; }
}

public class Permission<TKey>
    where TKey : IEquatable<TKey>
{
    public Permission() { }

    public Permission(string roleName)
        : this()
    {
        Name = roleName;
    }

    public virtual TKey Id { get; set; } = default!;

    public virtual string? Name { get; set; }

    public virtual string? NormalizedName { get; set; }

    public virtual string? ConcurrencyStamp { get; set; }

    public override string ToString()
    {
        return Name ?? string.Empty;
    }
}
