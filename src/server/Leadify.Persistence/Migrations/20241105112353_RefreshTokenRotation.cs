using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RefreshTokenRotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWM2PJG4BD0X590MJRJ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWM6BVCBSHY9SJ41TXQ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMA19EVZV3BFM7YS6K");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMAHVVM5FE1R6M8PEX");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMD53S15PM7RBNN4PM");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMFY8PG40RZRKGA135");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMGWH3EPVNCCBGMYKQ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMTWP785GAR6TTYSP7");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMVR1TG9EN4434FBCK");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMVRX78DVD1AG28N4G");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMW8P4SHVAPFAM91BH");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JBXH1GWMZHJV21XT10HP09GC");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBXH1GWPF7CMQTDGFZBGEASR");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBXH1GWPF8PF4VNAGJS27MAX");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JBXH1GWPXPQ03Y7CYD66DPZJ");

            migrationBuilder.AddColumn<bool>(
                name: "IsUsed",
                table: "SysRefreshTokens",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsUsed",
                table: "SysRefreshTokens");

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBXH1GWM2PJG4BD0X590MJRJ", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JBXH1GWM6BVCBSHY9SJ41TXQ", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JBXH1GWMA19EVZV3BFM7YS6K", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JBXH1GWMAHVVM5FE1R6M8PEX", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JBXH1GWMD53S15PM7RBNN4PM", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JBXH1GWMFY8PG40RZRKGA135", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JBXH1GWMGWH3EPVNCCBGMYKQ", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JBXH1GWMTWP785GAR6TTYSP7", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JBXH1GWMVR1TG9EN4434FBCK", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JBXH1GWMVRX78DVD1AG28N4G", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JBXH1GWMW8P4SHVAPFAM91BH", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JBXH1GWMZHJV21XT10HP09GC", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JBXH1GWPF7CMQTDGFZBGEASR", null, "Administrator", "ADMINISTRATOR" },
                    { "01JBXH1GWPF8PF4VNAGJS27MAX", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "01JBXH1GWPXPQ03Y7CYD66DPZJ", null, "User", "USER" }
                });
        }
    }
}
