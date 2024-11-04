using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RefreshTokenExpiresField2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGPZHJ38R09S20TYARFKR0");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGPZHJ7F0HAWGSRAXHSFBJ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGPZHJ8S477GBP57W44592");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGPZHJEXZSB7YGA87GN9QR");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGPZHJN4M9ENCKCNCP35HY");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGPZHJQ0P81J8YQZC7K9G8");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGPZHJQWD9T0MV08S81C2G");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGPZHJR3GM1RYTTCM3ZQY5");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGPZHJSXSGASR39C7N9BKR");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGPZHJV21AZYFSQT6S3KNV");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGPZHJW4BD4YFX55DMK400");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGPZHJYYYX9GVHYEJ7TA76");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBVGPZHK2NNPB71K4YWPD937");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBVGPZHK6B85DB7Q9FVV072K");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBVGPZHKGGTBY2QS32NK6PW0");

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBVGZVJT13Y787XSWHN2ZBR3", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JBVGZVJT2Y7SA8ZTE1APEH9Q", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JBVGZVJT4G3AWM11GY02B078", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JBVGZVJT4RT3AR5XMN5RTTME", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JBVGZVJT4TZF0DZNRSCJ8VZX", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JBVGZVJT5Q1GFS0RT8R3SXEB", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JBVGZVJT76KT8DWE3MWACKPW", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JBVGZVJTATQX9MSHQ0NZRQTB", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JBVGZVJTJZW4W5BGVVX1HW16", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JBVGZVJTS1AS082DH0SBYJCD", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JBVGZVJTW4EDF7E5YV7T10JB", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JBVGZVJTXHSTXYFFRT92A861", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBVGZVJW38HMTM8RD47R4H5M", null, "User", "USER" },
                    { "01JBVGZVJW8XSJZZBDSSHD60VZ", null, "Administrator", "ADMINISTRATOR" },
                    { "01JBVGZVJWYK9A17HMN642KZW8", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGZVJT13Y787XSWHN2ZBR3");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGZVJT2Y7SA8ZTE1APEH9Q");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGZVJT4G3AWM11GY02B078");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGZVJT4RT3AR5XMN5RTTME");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGZVJT4TZF0DZNRSCJ8VZX");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGZVJT5Q1GFS0RT8R3SXEB");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGZVJT76KT8DWE3MWACKPW");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGZVJTATQX9MSHQ0NZRQTB");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGZVJTJZW4W5BGVVX1HW16");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGZVJTS1AS082DH0SBYJCD");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGZVJTW4EDF7E5YV7T10JB");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVGZVJTXHSTXYFFRT92A861");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBVGZVJW38HMTM8RD47R4H5M");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBVGZVJW8XSJZZBDSSHD60VZ");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBVGZVJWYK9A17HMN642KZW8");

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBVGPZHJ38R09S20TYARFKR0", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JBVGPZHJ7F0HAWGSRAXHSFBJ", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JBVGPZHJ8S477GBP57W44592", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JBVGPZHJEXZSB7YGA87GN9QR", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JBVGPZHJN4M9ENCKCNCP35HY", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JBVGPZHJQ0P81J8YQZC7K9G8", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JBVGPZHJQWD9T0MV08S81C2G", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JBVGPZHJR3GM1RYTTCM3ZQY5", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JBVGPZHJSXSGASR39C7N9BKR", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JBVGPZHJV21AZYFSQT6S3KNV", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JBVGPZHJW4BD4YFX55DMK400", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JBVGPZHJYYYX9GVHYEJ7TA76", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBVGPZHK2NNPB71K4YWPD937", null, "Administrator", "ADMINISTRATOR" },
                    { "01JBVGPZHK6B85DB7Q9FVV072K", null, "User", "USER" },
                    { "01JBVGPZHKGGTBY2QS32NK6PW0", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });
        }
    }
}
