using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NgMenuData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Hierarchy",
                table: "NgMenus",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC2M6TFV8PF1PR1JXP8W6R78", 0, "pi pi-fw pi-home", "Dashboard", null, "/", null },
                    { "01JC2M6TFVNNP31Z83BFY8X7ZE", 1, "pi pi-fw pi-wallet", "Sales", null, "/", null }
                });

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC2M6TFW0G00ATENGN3DXCRT", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JC2M6TFW33Z626NPG74H2DX3", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JC2M6TFWEHVS4PT7BDTPGGK9", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JC2M6TFWG9F8V9JPD8YVNMCJ", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JC2M6TFWGKTSYD8H3R1JHEMD", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JC2M6TFWGNSNT9BSPHZHYZG9", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JC2M6TFWJMPAC1W1923R4NJS", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JC2M6TFWSKAXAHA1VQD2WTE5", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JC2M6TFWVFKXXY0A89SG4HP1", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JC2M6TFWWAZMA8CQX1MYXC0K", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JC2M6TFWYEP1KDEEXPTEHKM8", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JC2M6TFWZNH77NPZFEZSZGE2", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC2M6TFYE1DR3QJR81XG9AQX", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "01JC2M6TFYR7YWYBY2RKG1NS0F", null, "User", "USER" },
                    { "01JC2M6TFYST2QZGZ3890CQCBP", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC2M6TFVG8DPZN20G9T9PD15", 0, "pi pi-fw pi-id-card", "Leads", "01JC2M6TFVNNP31Z83BFY8X7ZE", "/", null },
                    { "01JC2M6TFVJ6HT8NXGGNMFZP3M", 3, "pi pi-fw pi-bookmark", "Opportunities", "01JC2M6TFVNNP31Z83BFY8X7ZE", "/", null },
                    { "01JC2M6TFVKVVC4ED2V4F7PZHC", 1, "pi pi-fw pi-address-book", "Contacts", "01JC2M6TFVNNP31Z83BFY8X7ZE", "/", null },
                    { "01JC2M6TFVNT3GCB4F4KCA2EXP", 2, "pi pi-fw pi-building", "Accounts", "01JC2M6TFVNNP31Z83BFY8X7ZE", "/", null },
                    { "01JC2M6TFV3HZA831J2BQGKKMF", 1, "pi pi-fw pi-list", "List View", "01JC2M6TFVNT3GCB4F4KCA2EXP", "/", null },
                    { "01JC2M6TFVB404Y71A6Z3XZ5BS", 0, "pi pi-fw pi-plus", "New Contact", "01JC2M6TFVKVVC4ED2V4F7PZHC", "/", null },
                    { "01JC2M6TFVCS4DPWYR4Z2CR0AD", 0, "pi pi-fw pi-plus", "New Lead", "01JC2M6TFVG8DPZN20G9T9PD15", "/", null },
                    { "01JC2M6TFVCSC57DMRRWFH2750", 0, "pi pi-fw pi-plus", "New Account", "01JC2M6TFVNT3GCB4F4KCA2EXP", "/", null },
                    { "01JC2M6TFVHF2CQT23W87CXE0Q", 0, "pi pi-fw pi-plus", "New Opportunity", "01JC2M6TFVJ6HT8NXGGNMFZP3M", "/", null },
                    { "01JC2M6TFVHNB8BBPPRP83Z8GP", 1, "pi pi-fw pi-list", "List View", "01JC2M6TFVJ6HT8NXGGNMFZP3M", "/", null },
                    { "01JC2M6TFVJHQ0CFB21AZ4MA8D", 1, "pi pi-fw pi-list", "List View", "01JC2M6TFVG8DPZN20G9T9PD15", "/", null },
                    { "01JC2M6TFVT8MK5C5TPJA53WH2", 1, "pi pi-fw pi-list", "List View", "01JC2M6TFVKVVC4ED2V4F7PZHC", "/", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFV3HZA831J2BQGKKMF");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFV8PF1PR1JXP8W6R78");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFVB404Y71A6Z3XZ5BS");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFVCS4DPWYR4Z2CR0AD");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFVCSC57DMRRWFH2750");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFVHF2CQT23W87CXE0Q");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFVHNB8BBPPRP83Z8GP");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFVJHQ0CFB21AZ4MA8D");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFVT8MK5C5TPJA53WH2");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2M6TFW0G00ATENGN3DXCRT");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2M6TFW33Z626NPG74H2DX3");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2M6TFWEHVS4PT7BDTPGGK9");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2M6TFWG9F8V9JPD8YVNMCJ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2M6TFWGKTSYD8H3R1JHEMD");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2M6TFWGNSNT9BSPHZHYZG9");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2M6TFWJMPAC1W1923R4NJS");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2M6TFWSKAXAHA1VQD2WTE5");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2M6TFWVFKXXY0A89SG4HP1");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2M6TFWWAZMA8CQX1MYXC0K");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2M6TFWYEP1KDEEXPTEHKM8");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2M6TFWZNH77NPZFEZSZGE2");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC2M6TFYE1DR3QJR81XG9AQX");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC2M6TFYR7YWYBY2RKG1NS0F");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC2M6TFYST2QZGZ3890CQCBP");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFVG8DPZN20G9T9PD15");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFVJ6HT8NXGGNMFZP3M");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFVKVVC4ED2V4F7PZHC");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFVNT3GCB4F4KCA2EXP");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2M6TFVNNP31Z83BFY8X7ZE");

            migrationBuilder.DropColumn(
                name: "Hierarchy",
                table: "NgMenus");

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
    }
}
