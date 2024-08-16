using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01J5DDXGHTRMBKYBQHX8V9HHGE", null, "SystemAdministrator", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01J5DDXGHTRMBKYBQHX8V9HHGE");
        }
    }
}
