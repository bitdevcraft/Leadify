using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RefreshTokenArray : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVDVT0P90AH166V3DNT7KPG");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVDVT0P90SG746DZNQKRXPY");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVDVT0P9C9H0XGAX53NEWB8");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVDVT0PBG8C6WKTC4FNQ76H");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVDVT0PDC1F080100EYAKR1");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVDVT0PEMETDA54C5ZXBE44");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVDVT0PNXK3EAYFBXPT5AH9");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVDVT0PPDV28JSX3XR5Z3DR");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVDVT0PV2DP7SXRWJCBQ0JN");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVDVT0PVC1JSEP8H1QJ3Z47");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVDVT0PXYENMKK5X395ABNY");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVDVT0PZBKBFMWMATTE1A4H");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBVDVT0QBB2AWY0WJVYWYMZ7");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBVDVT0QFW1J3SGPRF704T7Q");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBVDVT0QS8SE3K8T3PBQ5P60");

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBVFFTN1541P5KWFGPAA1RKG", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JBVFFTN17RKA43A5ZH11ECBA", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JBVFFTN19JYM2RHSTPNY6VSK", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JBVFFTN1BN5EZ4HAJV3BFHYR", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JBVFFTN1DM2V9RC1R8PCTAW7", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JBVFFTN1KNA10QG2PR0NZ88V", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JBVFFTN1Q5JPB8VR48FAHD4W", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JBVFFTN1QF07A5H6DPCP3Y3Y", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JBVFFTN1W231PG8GS02A95FA", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JBVFFTN1YG6RYDA3RCQ48PRW", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JBVFFTN1YTF08XGZ6ENCENP1", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JBVFFTN1ZQA2HDYPZQJVD05B", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBVFFTN28NDVKTRY8Z4W03V5", null, "User", "USER" },
                    { "01JBVFFTN2CCX6CV0FCSVP67K6", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "01JBVFFTN2S61QNGXBAD28BKQ4", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVFFTN1541P5KWFGPAA1RKG");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVFFTN17RKA43A5ZH11ECBA");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVFFTN19JYM2RHSTPNY6VSK");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVFFTN1BN5EZ4HAJV3BFHYR");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVFFTN1DM2V9RC1R8PCTAW7");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVFFTN1KNA10QG2PR0NZ88V");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVFFTN1Q5JPB8VR48FAHD4W");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVFFTN1QF07A5H6DPCP3Y3Y");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVFFTN1W231PG8GS02A95FA");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVFFTN1YG6RYDA3RCQ48PRW");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVFFTN1YTF08XGZ6ENCENP1");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBVFFTN1ZQA2HDYPZQJVD05B");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBVFFTN28NDVKTRY8Z4W03V5");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBVFFTN2CCX6CV0FCSVP67K6");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBVFFTN2S61QNGXBAD28BKQ4");

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBVDVT0P90AH166V3DNT7KPG", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JBVDVT0P90SG746DZNQKRXPY", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JBVDVT0P9C9H0XGAX53NEWB8", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JBVDVT0PBG8C6WKTC4FNQ76H", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JBVDVT0PDC1F080100EYAKR1", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JBVDVT0PEMETDA54C5ZXBE44", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JBVDVT0PNXK3EAYFBXPT5AH9", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JBVDVT0PPDV28JSX3XR5Z3DR", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JBVDVT0PV2DP7SXRWJCBQ0JN", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JBVDVT0PVC1JSEP8H1QJ3Z47", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JBVDVT0PXYENMKK5X395ABNY", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JBVDVT0PZBKBFMWMATTE1A4H", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBVDVT0QBB2AWY0WJVYWYMZ7", null, "User", "USER" },
                    { "01JBVDVT0QFW1J3SGPRF704T7Q", null, "Administrator", "ADMINISTRATOR" },
                    { "01JBVDVT0QS8SE3K8T3PBQ5P60", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });
        }
    }
}
