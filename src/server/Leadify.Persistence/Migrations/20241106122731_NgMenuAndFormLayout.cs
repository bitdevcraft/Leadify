using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NgMenuAndFormLayout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBY126ZJ0RX1N980Y0XETMEK");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBY126ZJ2Z8VM64ZE2WX6P2N");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBY126ZJ3367GDAP2QSSFAAZ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBY126ZJ4GTQEYDEJFMTGHR1");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBY126ZJ4TB69NH61BV05P53");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBY126ZJ7JQJ94X1SGSHSH0R");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBY126ZJCTMPQK5QM6JY1V8N");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBY126ZJJS194ED0VYK6HV5G");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBY126ZJJT5KCEQKFVEVDTE3");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBY126ZJP0K8YN3RTBS6J96V");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBY126ZJT15R33G9D1X35T1F");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBY126ZJX8QCE38QMVZKAQCV");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBY126ZK1R0MV4R81MYKQ45P");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBY126ZK2SCQYSBGBC7M7NNV");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBY126ZKAYAMG6E4YXM9DG47");

            migrationBuilder.CreateTable(
                name: "NgFormLayouts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    SmallText = table.Column<string>(type: "TEXT", nullable: true),
                    Placeholder = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    ObjectType = table.Column<string>(type: "TEXT", nullable: true),
                    Required = table.Column<bool>(type: "INTEGER", nullable: false),
                    ReadOnly = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgFormLayouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NgMenus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Label = table.Column<string>(type: "TEXT", nullable: true),
                    Icon = table.Column<string>(type: "TEXT", nullable: true),
                    RouterLinkArray = table.Column<string>(type: "TEXT", nullable: true),
                    UrlArray = table.Column<string>(type: "TEXT", nullable: true),
                    ParentId = table.Column<string>(type: "TEXT", nullable: true)
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

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC0Q3EX7674SKWKZST9SNWP2", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JC0Q3EX77BXRKSQ0EC8T9HCY", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JC0Q3EX78SYJKFMTN0CK1GAA", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JC0Q3EX78T19C4JCTNV3V3VZ", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JC0Q3EX7A6JXFJYRT5DMT6JT", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JC0Q3EX7EBC05SXD5YGJQ3K1", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JC0Q3EX7J2DVJKHRNW1MN34X", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JC0Q3EX7KBZR7SR8KM1WG257", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JC0Q3EX7P2ES4RF5JG7C51WS", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JC0Q3EX7RZZ0JWV6SNZ4QHPW", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JC0Q3EX7V1NHQX3R6GCMBQP8", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JC0Q3EX7WZW25XKZ1DGXW33G", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC0Q3EXA57E4VE4MEN0GV941", null, "Administrator", "ADMINISTRATOR" },
                    { "01JC0Q3EXAFH4CEFWZT671PGGC", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "01JC0Q3EXAG9X9ZVME9YCK0ZMP", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NgMenus_ParentId",
                table: "NgMenus",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NgFormLayouts");

            migrationBuilder.DropTable(
                name: "NgMenus");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC0Q3EX7674SKWKZST9SNWP2");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC0Q3EX77BXRKSQ0EC8T9HCY");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC0Q3EX78SYJKFMTN0CK1GAA");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC0Q3EX78T19C4JCTNV3V3VZ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC0Q3EX7A6JXFJYRT5DMT6JT");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC0Q3EX7EBC05SXD5YGJQ3K1");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC0Q3EX7J2DVJKHRNW1MN34X");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC0Q3EX7KBZR7SR8KM1WG257");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC0Q3EX7P2ES4RF5JG7C51WS");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC0Q3EX7RZZ0JWV6SNZ4QHPW");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC0Q3EX7V1NHQX3R6GCMBQP8");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC0Q3EX7WZW25XKZ1DGXW33G");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC0Q3EXA57E4VE4MEN0GV941");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC0Q3EXAFH4CEFWZT671PGGC");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC0Q3EXAG9X9ZVME9YCK0ZMP");

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBY126ZJ0RX1N980Y0XETMEK", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JBY126ZJ2Z8VM64ZE2WX6P2N", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JBY126ZJ3367GDAP2QSSFAAZ", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JBY126ZJ4GTQEYDEJFMTGHR1", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JBY126ZJ4TB69NH61BV05P53", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JBY126ZJ7JQJ94X1SGSHSH0R", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JBY126ZJCTMPQK5QM6JY1V8N", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JBY126ZJJS194ED0VYK6HV5G", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JBY126ZJJT5KCEQKFVEVDTE3", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JBY126ZJP0K8YN3RTBS6J96V", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JBY126ZJT15R33G9D1X35T1F", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JBY126ZJX8QCE38QMVZKAQCV", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBY126ZK1R0MV4R81MYKQ45P", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "01JBY126ZK2SCQYSBGBC7M7NNV", null, "User", "USER" },
                    { "01JBY126ZKAYAMG6E4YXM9DG47", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
