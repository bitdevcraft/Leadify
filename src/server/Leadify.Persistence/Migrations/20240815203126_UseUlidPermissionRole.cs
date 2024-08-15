using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UseUlidPermissionRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "SysPermissions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SysPermissions",
                type: "TEXT",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "SysPermissions",
                type: "TEXT",
                maxLength: 256,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "PermissionNameIndex",
                table: "SysPermissions",
                column: "NormalizedName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "PermissionNameIndex",
                table: "SysPermissions");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "SysPermissions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SysPermissions");

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "SysPermissions");
        }
    }
}
