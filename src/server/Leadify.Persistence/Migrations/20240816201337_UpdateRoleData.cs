using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5DDXGHTRMBKYBQHX8V9HHGE");

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01J5ED5ZQ1M1NBVPDGCY4C99NV", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5ED5ZQ1M1NBVPDGCY4C99NV");

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01J5DDXGHTRMBKYBQHX8V9HHGE", null, "SystemAdministrator", null });
        }
    }
}
