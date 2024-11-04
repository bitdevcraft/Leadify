using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RefreshTokenExpiresField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshToken_SysUsers_UserId",
                table: "RefreshToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefreshToken",
                table: "RefreshToken");

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

            migrationBuilder.RenameTable(
                name: "RefreshToken",
                newName: "SysRefreshToken");

            migrationBuilder.RenameIndex(
                name: "IX_RefreshToken_UserId",
                table: "SysRefreshToken",
                newName: "IX_SysRefreshToken_UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Expires",
                table: "SysRefreshToken",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysRefreshToken",
                table: "SysRefreshToken",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SysRefreshToken_SysUsers_UserId",
                table: "SysRefreshToken",
                column: "UserId",
                principalTable: "SysUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Expires",
                table: "SysRefreshToken");

            migrationBuilder.RenameTable(
                name: "SysRefreshToken",
                newName: "RefreshToken");

            migrationBuilder.RenameIndex(
                name: "IX_SysRefreshToken_UserId",
                table: "RefreshToken",
                newName: "IX_RefreshToken_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefreshToken",
                table: "RefreshToken",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshToken_SysUsers_UserId",
                table: "RefreshToken",
                column: "UserId",
                principalTable: "SysUsers",
                principalColumn: "Id");
        }
    }
}
