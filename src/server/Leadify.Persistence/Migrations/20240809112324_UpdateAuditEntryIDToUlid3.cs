using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAuditEntryIDToUlid3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AuditEntries",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldDefaultValue: "01J4VDWVC0HAYKDZBV8DG2BBZE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AuditEntries",
                type: "TEXT",
                nullable: false,
                defaultValue: "01J4VDWVC0HAYKDZBV8DG2BBZE",
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
