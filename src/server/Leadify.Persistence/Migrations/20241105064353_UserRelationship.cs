using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UserRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SysRefreshToken_SysUsers_UserId",
                table: "SysRefreshToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SysRefreshToken",
                table: "SysRefreshToken");

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

            migrationBuilder.RenameTable(
                name: "SysRefreshToken",
                newName: "SysRefreshTokens");

            migrationBuilder.RenameIndex(
                name: "IX_SysRefreshToken_UserId",
                table: "SysRefreshTokens",
                newName: "IX_SysRefreshTokens_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "SysRefreshTokens",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysRefreshTokens",
                table: "SysRefreshTokens",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SysUserActivities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ActivityType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    ActivityData = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    IpAddress = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    DeviceInfo = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUserActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysUserActivities_SysUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBXH1GWM2PJG4BD0X590MJRJ", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JBXH1GWM6BVCBSHY9SJ41TXQ", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JBXH1GWMA19EVZV3BFM7YS6K", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JBXH1GWMAHVVM5FE1R6M8PEX", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JBXH1GWMD53S15PM7RBNN4PM", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JBXH1GWMFY8PG40RZRKGA135", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JBXH1GWMGWH3EPVNCCBGMYKQ", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JBXH1GWMTWP785GAR6TTYSP7", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JBXH1GWMVR1TG9EN4434FBCK", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JBXH1GWMVRX78DVD1AG28N4G", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JBXH1GWMW8P4SHVAPFAM91BH", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JBXH1GWMZHJV21XT10HP09GC", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBXH1GWPF7CMQTDGFZBGEASR", null, "Administrator", "ADMINISTRATOR" },
                    { "01JBXH1GWPF8PF4VNAGJS27MAX", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "01JBXH1GWPXPQ03Y7CYD66DPZJ", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserActivities_UserId",
                table: "SysUserActivities",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SysRefreshTokens_SysUsers_UserId",
                table: "SysRefreshTokens",
                column: "UserId",
                principalTable: "SysUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SysRefreshTokens_SysUsers_UserId",
                table: "SysRefreshTokens");

            migrationBuilder.DropTable(
                name: "SysUserActivities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SysRefreshTokens",
                table: "SysRefreshTokens");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWM2PJG4BD0X590MJRJ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWM6BVCBSHY9SJ41TXQ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMA19EVZV3BFM7YS6K");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMAHVVM5FE1R6M8PEX");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMD53S15PM7RBNN4PM");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMFY8PG40RZRKGA135");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMGWH3EPVNCCBGMYKQ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMTWP785GAR6TTYSP7");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMVR1TG9EN4434FBCK");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMVRX78DVD1AG28N4G");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMW8P4SHVAPFAM91BH");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMZHJV21XT10HP09GC");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBXH1GWPF7CMQTDGFZBGEASR");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBXH1GWPF8PF4VNAGJS27MAX");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBXH1GWPXPQ03Y7CYD66DPZJ");

            migrationBuilder.RenameTable(
                name: "SysRefreshTokens",
                newName: "SysRefreshToken");

            migrationBuilder.RenameIndex(
                name: "IX_SysRefreshTokens_UserId",
                table: "SysRefreshToken",
                newName: "IX_SysRefreshToken_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "SysRefreshToken",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysRefreshToken",
                table: "SysRefreshToken",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SysRefreshToken_SysUsers_UserId",
                table: "SysRefreshToken",
                column: "UserId",
                principalTable: "SysUsers",
                principalColumn: "Id");
        }
    }
}
