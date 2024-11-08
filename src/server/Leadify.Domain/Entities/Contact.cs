using System.ComponentModel.DataAnnotations;
using Leadify.Domain.Primitives;

namespace Leadify.Domain.Entities;

public class Contact : Entity, IAuditableEntity
{
    [MaxLength(255)] public string? Name { get; set; }
    [MaxLength(50)] public string? FirstName { get; set; }
    [MaxLength(50)] public string? LastName { get; set; }
    [MaxLength(50)] public string? Email { get; set; }
    [MaxLength(50)] public string? Mobile { get; set; }
    [MaxLength(50)] public string? Phone { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }
}