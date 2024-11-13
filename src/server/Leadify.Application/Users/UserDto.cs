namespace Leadify.Application.Users;

public class UserDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? Suffix { get; set; }
    public string? Salutation { get; set; }
    public string? Mobile { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public string? Title { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? Role { get; set; }
    public string? Manager { get; set; }
    public Ulid? ManagerId { get; set; }
    public Ulid? RoleId { get; set; }
}