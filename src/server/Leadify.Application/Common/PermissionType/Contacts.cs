namespace Leadify.Application.Common.PermissionType;

public static class PermissionType
{
#pragma warning disable CA1034 // Nested types should not be visible
    public static class Contacts
    {
        public const string View = "Permissions.Contacts.View";
        public const string Create = "Permissions.Contacts.Create";
        public const string Edit = "Permissions.Contacts.Edit";
        public const string Delete = "Permissions.Contacts.Delete";
    }
#pragma warning restore CA1034 // Nested types should not be visible
}