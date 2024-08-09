using Leadify.Domain.Primitives;

namespace Leadify.Domain.Entities;

public class Contact : Entity, IAuditableEntity
{
    public Contact(Ulid id, string? name, string? email, string? mobile, string? phone)
        : base(id)
    {
        this.Name = name;
        this.Email = email;
        this.Mobile = mobile;
        this.Phone = phone;
    }

    public Contact() { }

    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Mobile { get; set; }
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
        var Contact = new Contact(id, name, email, mobile, phone);

        return Contact;
    }
}
