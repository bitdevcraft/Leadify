using System.ComponentModel.DataAnnotations;
using Leadify.Domain.Primitives;

namespace Leadify.Domain.Entities;

public class Contact : Entity, IAuditableEntity
{
    public Contact(Ulid id, string? name, string? email, string? mobile, string? phone)
        : base(id)
    {
        Name = name;
        Email = email;
        Mobile = mobile;
        Phone = phone;
    }

    public Contact() { }
    
    [MaxLength(100)]
    public string? Name { get; set; }
    [MaxLength(50)]
    public string? Email { get; set; }
    [MaxLength(50)]
    public string? Mobile { get; set; }
    [MaxLength(50)]
    public string? Phone { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }

    public static Contact Create(
        Ulid id,
        string? name,
        string? email,
        string? mobile,
        string? phone
    )
    {
        var contact = new Contact(id, name, email, mobile, phone);

        return contact;
    }
}
