using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NgMenuData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "NgMenus",
                columns: new[] { "Id", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC1C8WRPE76MQTCN4JD6W4CK", "pi pi-fw pi-wallet", "Sales", null, "/", null },
                    { "01JC1C8WRPHZ7CP43RWEHBEWVA", "pi pi-fw pi-home", "Dashboard", null, "/", null }
                });

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC1C8WRP24H89H0N5702VEKE", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JC1C8WRP2PCSRS56SGR1P7GJ", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JC1C8WRP6QRR0EWTX32DRFFC", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JC1C8WRP8XYTH4PNT7VNWK79", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JC1C8WRPFMW7X8P2BWGR14N7", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JC1C8WRPGXRNWCB0VD8RXCXP", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JC1C8WRPH7GDPCC7VWPRVMCK", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JC1C8WRPMM50KKFE5V2ZXV3Q", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JC1C8WRPNP6G0AQKY1MTEKB8", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JC1C8WRPP3AFCQX988VHC5RW", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JC1C8WRPPQ9K3XA2NQN8C5FE", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JC1C8WRPSD4DTFYZVWZ5AY7D", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC1C8WRQ2AEDGAWFA8A2FM71", null, "User", "USER" },
                    { "01JC1C8WRQMJKSX6QKMKXK066W", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "01JC1C8WRQYH56SJH5YK7ETF74", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC1C8WRP0MRXSP4CJY68CJPY", "pi pi-fw pi-address-book", "Contacts", "01JC1C8WRPE76MQTCN4JD6W4CK", "/", null },
                    { "01JC1C8WRP7K7D80FJ4SCZ3K60", "pi pi-fw pi-bookmark", "Opportunities", "01JC1C8WRPE76MQTCN4JD6W4CK", "/", null },
                    { "01JC1C8WRPDNYCHZH8MY99AD6E", "pi pi-fw pi-id-card", "Leads", "01JC1C8WRPE76MQTCN4JD6W4CK", "/", null },
                    { "01JC1C8WRPGX38AC30S6AZRXJ1", "pi pi-fw pi-building", "Accounts", "01JC1C8WRPE76MQTCN4JD6W4CK", "/", null },
                    { "01JC1C8WRP6JPTYK656F9X8X2G", "pi pi-fw pi-list", "List View", "01JC1C8WRPDNYCHZH8MY99AD6E", "/", null },
                    { "01JC1C8WRPCA6QRB73JMQX70G9", "pi pi-fw pi-list", "List View", "01JC1C8WRP0MRXSP4CJY68CJPY", "/", null },
                    { "01JC1C8WRPDXX4JZ4JNVYGNTPX", "pi pi-fw pi-plus", "New Opportunity", "01JC1C8WRP7K7D80FJ4SCZ3K60", "/", null },
                    { "01JC1C8WRPM4900T5Y131ME3PN", "pi pi-fw pi-plus", "New Lead", "01JC1C8WRPDNYCHZH8MY99AD6E", "/", null },
                    { "01JC1C8WRPMANDY576CSS43KBZ", "pi pi-fw pi-plus", "New Contact", "01JC1C8WRP0MRXSP4CJY68CJPY", "/", null },
                    { "01JC1C8WRPTVFWR8797ADVZ5C0", "pi pi-fw pi-list", "List View", "01JC1C8WRPGX38AC30S6AZRXJ1", "/", null },
                    { "01JC1C8WRPWP71PW6PD667CM2N", "pi pi-fw pi-list", "List View", "01JC1C8WRP7K7D80FJ4SCZ3K60", "/", null },
                    { "01JC1C8WRPYMMDSYV92C2HJM4F", "pi pi-fw pi-plus", "New Account", "01JC1C8WRPGX38AC30S6AZRXJ1", "/", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRP6JPTYK656F9X8X2G");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPCA6QRB73JMQX70G9");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPDXX4JZ4JNVYGNTPX");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPHZ7CP43RWEHBEWVA");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPM4900T5Y131ME3PN");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPMANDY576CSS43KBZ");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPTVFWR8797ADVZ5C0");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPWP71PW6PD667CM2N");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPYMMDSYV92C2HJM4F");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1C8WRP24H89H0N5702VEKE");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1C8WRP2PCSRS56SGR1P7GJ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1C8WRP6QRR0EWTX32DRFFC");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1C8WRP8XYTH4PNT7VNWK79");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPFMW7X8P2BWGR14N7");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPGXRNWCB0VD8RXCXP");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPH7GDPCC7VWPRVMCK");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPMM50KKFE5V2ZXV3Q");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPNP6G0AQKY1MTEKB8");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPP3AFCQX988VHC5RW");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPPQ9K3XA2NQN8C5FE");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPSD4DTFYZVWZ5AY7D");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC1C8WRQ2AEDGAWFA8A2FM71");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC1C8WRQMJKSX6QKMKXK066W");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC1C8WRQYH56SJH5YK7ETF74");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRP0MRXSP4CJY68CJPY");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRP7K7D80FJ4SCZ3K60");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPDNYCHZH8MY99AD6E");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPGX38AC30S6AZRXJ1");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1C8WRPE76MQTCN4JD6W4CK");

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
        }
    }
}
