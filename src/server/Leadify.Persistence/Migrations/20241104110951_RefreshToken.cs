using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    Token = table.Column<string>(type: "TEXT", nullable: true),
                    Revoked = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_SysUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SysUsers",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshToken");

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
    }
}
