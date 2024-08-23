using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewSeedPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5Z6N24QAPMN8SV2SVFCC2KJ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5Z6N24QCD8D7S9R6DVXS0QE");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5Z6N24QDA0Q04HJWEG4HVGE");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5Z6N24QWMVRE2XNZDENFJC2");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5Z6N24R5S5M1QWSRZ30HG8E");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5Z6N24RFZ205WR1KRE6MZAQ");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5Z6N24RP9JYSWQ61AMRACYY");

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01J5ZGC7N112MHX4Q0YQ8E1QHG", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01J5ZGC7N12DMY6V898RR5406V", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01J5ZGC7N14HQ9MFTY3H2B8JWB", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01J5ZGC7N179EXNQSJBH1TPFX8", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01J5ZGC7N18EE1V9EQ6KTARYBF", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01J5ZGC7N1CD954PVC7Z2PNQVD", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01J5ZGC7N1FRBTNJ81N9AQNMGC", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01J5ZGC7N1H4WQEA4XSGHM231H", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01J5ZGC7N1ND92GMFZM32MHZMQ", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01J5ZGC7N1NQ1TEAMX1N8K01YS", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01J5ZGC7N1S9Q4ZK4BQJ4J3GGZ", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01J5ZGC7N1T14G09GDCT93YRCZ", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01J5ZGC7N22E1DC6JHS4F73G2N", null, "User", "USER" },
                    { "01J5ZGC7N23FYJ6YZSKDS3D603", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "01J5ZGC7N2TS44F2GJW46N779X", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N112MHX4Q0YQ8E1QHG");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N12DMY6V898RR5406V");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N14HQ9MFTY3H2B8JWB");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N179EXNQSJBH1TPFX8");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N18EE1V9EQ6KTARYBF");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N1CD954PVC7Z2PNQVD");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N1FRBTNJ81N9AQNMGC");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N1H4WQEA4XSGHM231H");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N1ND92GMFZM32MHZMQ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N1NQ1TEAMX1N8K01YS");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N1S9Q4ZK4BQJ4J3GGZ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N1T14G09GDCT93YRCZ");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N22E1DC6JHS4F73G2N");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N23FYJ6YZSKDS3D603");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5ZGC7N2TS44F2GJW46N779X");

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01J5Z6N24QAPMN8SV2SVFCC2KJ", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01J5Z6N24QCD8D7S9R6DVXS0QE", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01J5Z6N24QDA0Q04HJWEG4HVGE", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01J5Z6N24QWMVRE2XNZDENFJC2", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01J5Z6N24R5S5M1QWSRZ30HG8E", null, "Administrator", "ADMINISTRATOR" },
                    { "01J5Z6N24RFZ205WR1KRE6MZAQ", null, "User", "USER" },
                    { "01J5Z6N24RP9JYSWQ61AMRACYY", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });
        }
    }
}
