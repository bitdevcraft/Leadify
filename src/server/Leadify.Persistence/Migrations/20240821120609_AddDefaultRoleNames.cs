using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultRoleNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5QX21B2P2TRDWMJAMBES9W7");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01J5QX21B2P2TRDWMJAMBES9W7", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" });
        }
    }
}
