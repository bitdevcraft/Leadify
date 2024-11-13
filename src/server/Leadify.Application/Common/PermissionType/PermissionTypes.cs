using System.Diagnostics.CodeAnalysis;

namespace Leadify.Application.Common.PermissionType;

[SuppressMessage("Design", "CA1034:Nested types should not be visible")]
public static partial class PermissionType
{
    public static class Contacts
    {
        public const string View = "Permissions.Contacts.View";
        public const string Create = "Permissions.Contacts.Create";
        public const string Edit = "Permissions.Contacts.Edit";
        public const string Delete = "Permissions.Contacts.Delete";
    }

    public static class Roles
    {
        public const string View = "Permissions.Roles.View";
        public const string Create = "Permissions.Roles.Create";
        public const string Edit = "Permissions.Roles.Edit";
        public const string Delete = "Permissions.Roles.Delete";
    }

    public static class Permissions
    {
        public const string View = "Permissions.Permissions.View";
        public const string Create = "Permissions.Permissions.Create";
        public const string Edit = "Permissions.Permissions.Edit";
        public const string Delete = "Permissions.Permissions.Delete";
    }

    public static class Users
    {
        public const string View = "Permissions.Users.View";
        public const string Create = "Permissions.Users.Create";
        public const string Edit = "Permissions.Users.Edit";
        public const string Delete = "Permissions.Users.Delete";
    }

    public static class NgMenus
    {
        public const string View = "Permissions.NgMenus.View";
        public const string Create = "Permissions.NgMenus.Create";
        public const string Edit = "Permissions.NgMenus.Edit";
        public const string Delete = "Permissions.NgMenus.Delete";
    }
}