using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AuditableEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnUtc",
                table: "Contacts",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOnUtc",
                table: "Contacts",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOnUtc",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ModifiedOnUtc",
                table: "Contacts");
        }
    }
}
