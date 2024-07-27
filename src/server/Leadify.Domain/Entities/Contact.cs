using Leadify.Domain.Primitives;

namespace Leadify.Domain.Entities;

public class Contact : Entity
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Mobile { get; set; }
    public string? Phone { get; set; }
}
