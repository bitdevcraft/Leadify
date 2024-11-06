using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NgMenuData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "NgMenus",
                columns: new[] { "Id", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC1PQYR9EHYSETWT8TPHHSPR", "pi pi-fw pi-wallet", "Sales", null, "/", null },
                    { "01JC1PQYR9V7N9N449H6VMWKR2", "pi pi-fw pi-home", "Dashboard", null, "/", null }
                });

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC1PQYR94J76NKR1KC43BENY", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JC1PQYR94Y8ECNKQXAAZ6XMH", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JC1PQYR966M6KEY1DR0W9RZH", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JC1PQYR9AY4MCX99XGV5YS0B", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JC1PQYR9BEFW48WMJVP5165W", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JC1PQYR9EJXB8S3WVFBHZP3T", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JC1PQYR9HMJ3SYDFE2TDY3ZV", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JC1PQYR9HZ7CP6G77TKM1V8K", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JC1PQYR9NECGTN0KQ11KDBVR", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JC1PQYR9NPFGKPBQS0BE7FHJ", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JC1PQYR9XR0HBEZQWY4SZRR0", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JC1PQYR9YK5PSPCCVNPC45H7", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC1PQYRB41C099S07E6EH87D", null, "User", "USER" },
                    { "01JC1PQYRB4E06QH1P8DGNZFCM", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "01JC1PQYRBJFDSME67P5TQZZ7H", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC1PQYR91SEY60FP84YZY70B", "pi pi-fw pi-building", "Accounts", "01JC1PQYR9EHYSETWT8TPHHSPR", "/", null },
                    { "01JC1PQYR93E5SHWAY59T25GRN", "pi pi-fw pi-bookmark", "Opportunities", "01JC1PQYR9EHYSETWT8TPHHSPR", "/", null },
                    { "01JC1PQYR9G19WKTJKAV523ZB5", "pi pi-fw pi-address-book", "Contacts", "01JC1PQYR9EHYSETWT8TPHHSPR", "/", null },
                    { "01JC1PQYR9RXVRTQ1XHTW1WP3M", "pi pi-fw pi-id-card", "Leads", "01JC1PQYR9EHYSETWT8TPHHSPR", "/", null },
                    { "01JC1PQYR96CP2JTDTM7NT3JSX", "pi pi-fw pi-list", "List View", "01JC1PQYR91SEY60FP84YZY70B", "/", null },
                    { "01JC1PQYR9CCMTZTYX76MZJ5KH", "pi pi-fw pi-list", "List View", "01JC1PQYR93E5SHWAY59T25GRN", "/", null },
                    { "01JC1PQYR9CRMJP4HHFXFTKDFQ", "pi pi-fw pi-list", "List View", "01JC1PQYR9RXVRTQ1XHTW1WP3M", "/", null },
                    { "01JC1PQYR9GTQ705003JT9YG70", "pi pi-fw pi-plus", "New Lead", "01JC1PQYR9RXVRTQ1XHTW1WP3M", "/", null },
                    { "01JC1PQYR9HA1TKH1F5Z5T10AV", "pi pi-fw pi-list", "List View", "01JC1PQYR9G19WKTJKAV523ZB5", "/", null },
                    { "01JC1PQYR9N3DTY70ZMVNX3SWP", "pi pi-fw pi-plus", "New Contact", "01JC1PQYR9G19WKTJKAV523ZB5", "/", null },
                    { "01JC1PQYR9TYXBYSWHD7MQSAQ3", "pi pi-fw pi-plus", "New Opportunity", "01JC1PQYR93E5SHWAY59T25GRN", "/", null },
                    { "01JC1PQYR9W7V25CY50KP2E80N", "pi pi-fw pi-plus", "New Account", "01JC1PQYR91SEY60FP84YZY70B", "/", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR96CP2JTDTM7NT3JSX");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9CCMTZTYX76MZJ5KH");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9CRMJP4HHFXFTKDFQ");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9GTQ705003JT9YG70");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9HA1TKH1F5Z5T10AV");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9N3DTY70ZMVNX3SWP");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9TYXBYSWHD7MQSAQ3");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9V7N9N449H6VMWKR2");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9W7V25CY50KP2E80N");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1PQYR94J76NKR1KC43BENY");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1PQYR94Y8ECNKQXAAZ6XMH");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1PQYR966M6KEY1DR0W9RZH");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9AY4MCX99XGV5YS0B");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9BEFW48WMJVP5165W");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9EJXB8S3WVFBHZP3T");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9HMJ3SYDFE2TDY3ZV");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9HZ7CP6G77TKM1V8K");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9NECGTN0KQ11KDBVR");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9NPFGKPBQS0BE7FHJ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9XR0HBEZQWY4SZRR0");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9YK5PSPCCVNPC45H7");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC1PQYRB41C099S07E6EH87D");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC1PQYRB4E06QH1P8DGNZFCM");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC1PQYRBJFDSME67P5TQZZ7H");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR91SEY60FP84YZY70B");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR93E5SHWAY59T25GRN");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9G19WKTJKAV523ZB5");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9RXVRTQ1XHTW1WP3M");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC1PQYR9EHYSETWT8TPHHSPR");

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
    }
}
