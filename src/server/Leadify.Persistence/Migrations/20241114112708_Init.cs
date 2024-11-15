using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NgFormLayouts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SmallText = table.Column<string>(type: "text", nullable: true),
                    Placeholder = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    ObjectType = table.Column<string>(type: "text", nullable: true),
                    Required = table.Column<bool>(type: "boolean", nullable: false),
                    ReadOnly = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgFormLayouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NgMenus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    Label = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    RouterLinkArray = table.Column<string>(type: "text", nullable: true),
                    UrlArray = table.Column<string>(type: "text", nullable: true),
                    ParentId = table.Column<string>(type: "character varying(26)", nullable: true),
                    CanDelete = table.Column<bool>(type: "boolean", nullable: false),
                    Hierarchy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NgMenus_NgMenus_ParentId",
                        column: x => x.ParentId,
                        principalTable: "NgMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Operation = table.Column<string>(type: "text", nullable: true),
                    TableName = table.Column<string>(type: "text", nullable: true),
                    RecordId = table.Column<string>(type: "character varying(26)", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysPermissions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    ManagerId = table.Column<string>(type: "character varying(26)", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    MiddleName = table.Column<string>(type: "text", nullable: true),
                    Suffix = table.Column<string>(type: "text", nullable: true),
                    Salutation = table.Column<string>(type: "text", nullable: true),
                    Mobile = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Fax = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysUsers_SysUsers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysAuditEntries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    FieldName = table.Column<string>(type: "text", nullable: true),
                    OldValue = table.Column<string>(type: "text", nullable: true),
                    NewValue = table.Column<string>(type: "text", nullable: true),
                    AuditId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysAuditEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysAuditEntries_SysAudits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "SysAudits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "character varying(26)", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_SysRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "SysRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysRolePermissions",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "character varying(26)", nullable: false),
                    PermissionId = table.Column<string>(type: "character varying(26)", nullable: false),
                    Id = table.Column<string>(type: "character varying(26)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_SysUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_SysUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_SysUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysRefreshTokens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false),
                    Token = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Expires = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Revoked = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsUsed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysRefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysRefreshTokens_SysUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysUserActivities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false),
                    ActivityType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ActivityData = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    IpAddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    DeviceInfo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "SysUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false),
                    RoleId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUserRoles", x => new { x.UserId, x.RoleId });
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

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedOnUtc", "Email", "FirstName", "LastName", "Mobile", "ModifiedOnUtc", "Name", "Phone" },
                values: new object[,]
                {
                    { "01JCN6TMCF2T7D8R316FPMM5G4", new DateTime(2024, 11, 14, 11, 27, 7, 663, DateTimeKind.Utc).AddTicks(5929), "charlie.davis@example.com", null, null, "+789012345", null, "Charlie Davis", "+321654987" },
                    { "01JCN6TMCF61N8JJXX4HS8A4SF", new DateTime(2024, 11, 14, 11, 27, 7, 663, DateTimeKind.Utc).AddTicks(5913), "john.doe@example.com", null, null, "+123456789", null, "John Doe", "+987654321" },
                    { "01JCN6TMCF9T1NRNJ8PQ7FZPZ7", new DateTime(2024, 11, 14, 11, 27, 7, 663, DateTimeKind.Utc).AddTicks(5920), "jane.smith@example.com", null, null, "+987654321", null, "Jane Smith", "+123456789" },
                    { "01JCN6TMCFVHHSMN45GNNPW1AC", new DateTime(2024, 11, 14, 11, 27, 7, 663, DateTimeKind.Utc).AddTicks(5926), "bob.johnson@example.com", null, null, "+567890123", null, "Bob Johnson", "+210987654" },
                    { "01JCN6TMCFW34QRZKRPJB19A8T", new DateTime(2024, 11, 14, 11, 27, 7, 663, DateTimeKind.Utc).AddTicks(5923), "alice.brown@example.com", null, null, "+1029384756", null, "Alice Brown", "+5647382910" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "CanDelete", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JCN6TMCN4G12R8RYQSD04JXD", false, 1, "pi pi-fw pi-cog", "Setup", null, null, null },
                    { "01JCN6TMCNA7H38EPS5AFE6B4N", true, 0, "pi pi-fw pi-wallet", "Sales", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JCN6TMCP051A0V207TKD892B", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JCN6TMCP7MT2GAFHN815QPD4", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JCN6TMCPAJKN4SY6SG96XCY9", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JCN6TMCPAXWKXZR40BFDCNP3", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JCN6TMCPB3RQCBZ6V6XZ93E7", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JCN6TMCPHE9J0R9G41TWX5KR", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JCN6TMCPHSEM7C2WD3KMQV3C", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JCN6TMCPN5NZDV5HDPCTMY41", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JCN6TMCPPMT04CJTMAQDJD8P", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JCN6TMCPQKPEAEWBJ9N2S8XT", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JCN6TMCPQR3X5SD5EETM85J8", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JCN6TMCPYT7MS4EMKGWCT060", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JCN6TMCR212QD20CSC9F9TZ9", null, "User", "USER" },
                    { "01JCN6TMCRKE9F9ECMP8QYJQV3", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "01JCN6TMCRTMKV67MBKQ7T63DA", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "CanDelete", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JCN6TMCN8HN60A8ZM55DJEZT", true, 2, "pi pi-fw pi-building", "Accounts", "01JCN6TMCNA7H38EPS5AFE6B4N", null, null },
                    { "01JCN6TMCNA56J6QV69SFK2SK2", true, 1, "pi pi-fw pi-address-book", "Contacts", "01JCN6TMCNA7H38EPS5AFE6B4N", null, null },
                    { "01JCN6TMCNFZQ9FSP8XEM6RXV1", false, 0, "pi pi-fw pi-users", "Administrations", "01JCN6TMCN4G12R8RYQSD04JXD", null, null },
                    { "01JCN6TMCNNKEEJWR46WBV5X9N", true, 3, "pi pi-fw pi-bookmark", "Opportunities", "01JCN6TMCNA7H38EPS5AFE6B4N", null, null },
                    { "01JCN6TMCNR5R4K4QVGZ6KHHMC", false, 1, "pi pi-fw pi-wrench", "Settings", "01JCN6TMCN4G12R8RYQSD04JXD", null, null },
                    { "01JCN6TMCNYRSD4VN2BPNBDQ3F", true, 0, "pi pi-fw pi-id-card", "Leads", "01JCN6TMCNA7H38EPS5AFE6B4N", null, null },
                    { "01JCN6TMCN1J54N5XWP82S66HW", false, 1, "pi pi-fw ", "Roles", "01JCN6TMCNFZQ9FSP8XEM6RXV1", "/setup/administrations/role", null },
                    { "01JCN6TMCN73DDQBJGYQTVPYPD", true, 0, "pi pi-fw pi-plus", "New Account", "01JCN6TMCN8HN60A8ZM55DJEZT", "/r/Accounts/new", null },
                    { "01JCN6TMCNCWQTKXR9367C1HC4", true, 1, "pi pi-fw pi-list", "List View", "01JCN6TMCNA56J6QV69SFK2SK2", "/r/Contacts/list-view", null },
                    { "01JCN6TMCNEPH3KWV7VJASF3H6", true, 0, "pi pi-fw pi-plus", "New Opportunity", "01JCN6TMCNNKEEJWR46WBV5X9N", "/r/Opportunities/new", null },
                    { "01JCN6TMCNHTG7VEWAV1BC0SWV", true, 1, "pi pi-fw pi-list", "List View", "01JCN6TMCNNKEEJWR46WBV5X9N", "/r/Opportunities/list-view", null },
                    { "01JCN6TMCNJAQT22H56P79JT1S", false, 0, "pi pi-fw", "Permissions", "01JCN6TMCNFZQ9FSP8XEM6RXV1", "/setup/administrations/permission", null },
                    { "01JCN6TMCNN8CMSE8B6J5AKTBA", true, 0, "pi pi-fw pi-plus", "New Lead", "01JCN6TMCNYRSD4VN2BPNBDQ3F", "/r/Leads/new", null },
                    { "01JCN6TMCNNHAYVRW553Y2ZCGY", true, 0, "pi pi-fw pi-plus", "New Contact", "01JCN6TMCNA56J6QV69SFK2SK2", "/r/Contacts/new", null },
                    { "01JCN6TMCNQ90386AE5X0DX2BZ", true, 1, "pi pi-fw pi-list", "List View", "01JCN6TMCN8HN60A8ZM55DJEZT", "/r/Accounts/list-view", null },
                    { "01JCN6TMCNRFT8K3VT2ENE8207", true, 1, "pi pi-fw pi-list", "List View", "01JCN6TMCNYRSD4VN2BPNBDQ3F", "/r/Leads/list-view", null },
                    { "01JCN6TMCNTD4R7CM4D2EDKQCM", false, 2, "pi pi-fw ", "Users", "01JCN6TMCNFZQ9FSP8XEM6RXV1", "/setup/administrations/user", null },
                    { "01JCN6TMCNZAEWM8YBYG9VP9EW", false, 0, "pi pi-fw", "Menu Settings", "01JCN6TMCNR5R4K4QVGZ6KHHMC", "/setup/settings/menu", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NgMenus_ParentId",
                table: "NgMenus",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_SysAuditEntries_AuditId",
                table: "SysAuditEntries",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "PermissionNameIndex",
                table: "SysPermissions",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SysRefreshTokens_UserId",
                table: "SysRefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysRolePermissions_PermissionId",
                table: "SysRolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "SysRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SysUserActivities_UserId",
                table: "SysUserActivities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysUserRoles_RoleId",
                table: "SysUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "SysUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_SysUsers_ManagerId",
                table: "SysUsers",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "SysUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "NgFormLayouts");

            migrationBuilder.DropTable(
                name: "NgMenus");

            migrationBuilder.DropTable(
                name: "SysAuditEntries");

            migrationBuilder.DropTable(
                name: "SysRefreshTokens");

            migrationBuilder.DropTable(
                name: "SysRolePermissions");

            migrationBuilder.DropTable(
                name: "SysUserActivities");

            migrationBuilder.DropTable(
                name: "SysUserRoles");

            migrationBuilder.DropTable(
                name: "SysAudits");

            migrationBuilder.DropTable(
                name: "SysPermissions");

            migrationBuilder.DropTable(
                name: "SysRoles");

            migrationBuilder.DropTable(
                name: "SysUsers");
        }
    }
}
