using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRolePermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditEntries_Audits_AuditId",
                table: "AuditEntries");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Audits",
                table: "Audits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditEntries",
                table: "AuditEntries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "Audits",
                newName: "SysAudits");

            migrationBuilder.RenameTable(
                name: "AuditEntries",
                newName: "SysAuditEntries");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "SysUsers");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "SysRoles");

            migrationBuilder.RenameIndex(
                name: "IX_AuditEntries_AuditId",
                table: "SysAuditEntries",
                newName: "IX_SysAuditEntries_AuditId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysAudits",
                table: "SysAudits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysAuditEntries",
                table: "SysAuditEntries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysUsers",
                table: "SysUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysRoles",
                table: "SysRoles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SysPermissions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_SysUserRoles_AspNetUserRoles_UserId_RoleId",
                        columns: x => new { x.UserId, x.RoleId },
                        principalTable: "AspNetUserRoles",
                        principalColumns: new[] { "UserId", "RoleId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SysUserRoles_SysRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "SysRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SysUserRoles_SysUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysRolePermissions",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    PermissionId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysRolePermissions", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_SysRolePermissions_SysPermissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "SysPermissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SysRolePermissions_SysRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "SysRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SysRolePermissions_PermissionId",
                table: "SysRolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SysUserRoles_RoleId",
                table: "SysUserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_SysRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "SysRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_SysUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "SysUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_SysUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "SysUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_SysUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "SysUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SysAuditEntries_SysAudits_AuditId",
                table: "SysAuditEntries",
                column: "AuditId",
                principalTable: "SysAudits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_SysRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_SysUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_SysUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_SysUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_SysAuditEntries_SysAudits_AuditId",
                table: "SysAuditEntries");

            migrationBuilder.DropTable(
                name: "SysRolePermissions");

            migrationBuilder.DropTable(
                name: "SysUserRoles");

            migrationBuilder.DropTable(
                name: "SysPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SysUsers",
                table: "SysUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SysRoles",
                table: "SysRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SysAudits",
                table: "SysAudits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SysAuditEntries",
                table: "SysAuditEntries");

            migrationBuilder.RenameTable(
                name: "SysUsers",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "SysRoles",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "SysAudits",
                newName: "Audits");

            migrationBuilder.RenameTable(
                name: "SysAuditEntries",
                newName: "AuditEntries");

            migrationBuilder.RenameIndex(
                name: "IX_SysAuditEntries_AuditId",
                table: "AuditEntries",
                newName: "IX_AuditEntries_AuditId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Audits",
                table: "Audits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditEntries",
                table: "AuditEntries",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditEntries_Audits_AuditId",
                table: "AuditEntries",
                column: "AuditId",
                principalTable: "Audits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
