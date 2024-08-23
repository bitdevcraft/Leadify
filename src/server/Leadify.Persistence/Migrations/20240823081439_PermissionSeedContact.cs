using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PermissionSeedContact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5TD8ZQ536JRV538XYQVQE21");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5TD8ZQ5E252KXBKFBCBYPW4");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5TD8ZQ5X77394PDZ3Z2DT4N");

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01J5Z4THYX69GWW0W340NM6D5A", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01J5Z4THYXBSCEAQDJXT65X3GF", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01J5Z4THYXQHJY2YXJ8ATABT4P", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01J5Z4THYXW2C98QXM3XGXR6Z3", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01J5Z4THYY0ZE6GR48BZ9WM9QK", null, "Administrator", "ADMINISTRATOR" },
                    { "01J5Z4THYY8A49CCEYR1AGV7JS", null, "User", "USER" },
                    { "01J5Z4THYYMH6AP30CP7WXM6C7", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5Z4THYX69GWW0W340NM6D5A");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5Z4THYXBSCEAQDJXT65X3GF");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5Z4THYXQHJY2YXJ8ATABT4P");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5Z4THYXW2C98QXM3XGXR6Z3");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5Z4THYY0ZE6GR48BZ9WM9QK");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5Z4THYY8A49CCEYR1AGV7JS");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5Z4THYYMH6AP30CP7WXM6C7");

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01J5TD8ZQ536JRV538XYQVQE21", null, "User", "USER" },
                    { "01J5TD8ZQ5E252KXBKFBCBYPW4", null, "Administrator", "ADMINISTRATOR" },
                    { "01J5TD8ZQ5X77394PDZ3Z2DT4N", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });
        }
    }
}
