using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NgMenuData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[] { "01JC2NZC759NAK9KSKERT7TH7V", 1, "pi pi-fw pi-wallet", "Sales", null, "/", null });

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC2NZC763AASCGVQCH4TTKHF", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JC2NZC7662WT0M12FJXHJ6V7", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JC2NZC766PCK9PK0X4F4F5HA", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JC2NZC76FPB2KSH5Y69Y9QNB", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JC2NZC76G1S1J0H51380WFE5", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JC2NZC76GK4G30S3WN9WXE6M", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JC2NZC76KSE1E44N1DXPT0MG", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JC2NZC76M0EWD5V3N3WFCX4T", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JC2NZC76M22RNAN6K7QAXT4V", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JC2NZC76T0CJG14S1SJ9SWG3", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JC2NZC76TH3C4VDWM29D6QD3", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JC2NZC76ZJG9615AZ89FBQMF", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC2NZC778PENNCQE7ZJ06KFV", null, "Administrator", "ADMINISTRATOR" },
                    { "01JC2NZC77JQ2D5NKZJ3SA5FXC", null, "User", "USER" },
                    { "01JC2NZC77T9HSFVM7H59XA3D6", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC2NZC752KGJ2FXNZNYNPXRX", 3, "pi pi-fw pi-bookmark", "Opportunities", "01JC2NZC759NAK9KSKERT7TH7V", "/", null },
                    { "01JC2NZC753TZGDVPGVPX5J0QJ", 0, "pi pi-fw pi-id-card", "Leads", "01JC2NZC759NAK9KSKERT7TH7V", "/", null },
                    { "01JC2NZC75SHXC4K9XK3PFT0ZX", 2, "pi pi-fw pi-building", "Accounts", "01JC2NZC759NAK9KSKERT7TH7V", "/", null },
                    { "01JC2NZC75Y0ZD7NZ2VQAVFWJR", 1, "pi pi-fw pi-address-book", "Contacts", "01JC2NZC759NAK9KSKERT7TH7V", "/", null },
                    { "01JC2NZC7583MP9HW1C8ZA6X8D", 0, "pi pi-fw pi-plus", "New Opportunity", "01JC2NZC752KGJ2FXNZNYNPXRX", "/", null },
                    { "01JC2NZC75BS2EPGXZKQRE4B28", 1, "pi pi-fw pi-list", "List View", "01JC2NZC752KGJ2FXNZNYNPXRX", "/", null },
                    { "01JC2NZC75FZRXHQAZKJVW25B6", 1, "pi pi-fw pi-list", "List View", "01JC2NZC75SHXC4K9XK3PFT0ZX", "/", null },
                    { "01JC2NZC75H9801T45E72CV7F8", 1, "pi pi-fw pi-list", "List View", "01JC2NZC753TZGDVPGVPX5J0QJ", "/", null },
                    { "01JC2NZC75HG3ASBVXZD75EFMW", 1, "pi pi-fw pi-list", "List View", "01JC2NZC75Y0ZD7NZ2VQAVFWJR", "/", null },
                    { "01JC2NZC75J2PE5JZJXBNAPZ99", 0, "pi pi-fw pi-plus", "New Account", "01JC2NZC75SHXC4K9XK3PFT0ZX", "/", null },
                    { "01JC2NZC75YH8E3AQC7XF3EY5J", 0, "pi pi-fw pi-plus", "New Contact", "01JC2NZC75Y0ZD7NZ2VQAVFWJR", "/", null },
                    { "01JC2NZC75YRXDCMVSQFXDCF72", 0, "pi pi-fw pi-plus", "New Lead", "01JC2NZC753TZGDVPGVPX5J0QJ", "/", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC7583MP9HW1C8ZA6X8D");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75BS2EPGXZKQRE4B28");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75FZRXHQAZKJVW25B6");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75H9801T45E72CV7F8");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75HG3ASBVXZD75EFMW");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75J2PE5JZJXBNAPZ99");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75YH8E3AQC7XF3EY5J");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75YRXDCMVSQFXDCF72");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC763AASCGVQCH4TTKHF");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC7662WT0M12FJXHJ6V7");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC766PCK9PK0X4F4F5HA");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76FPB2KSH5Y69Y9QNB");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76G1S1J0H51380WFE5");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76GK4G30S3WN9WXE6M");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76KSE1E44N1DXPT0MG");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76M0EWD5V3N3WFCX4T");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76M22RNAN6K7QAXT4V");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76T0CJG14S1SJ9SWG3");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76TH3C4VDWM29D6QD3");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76ZJG9615AZ89FBQMF");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC2NZC778PENNCQE7ZJ06KFV");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC2NZC77JQ2D5NKZJ3SA5FXC");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC2NZC77T9HSFVM7H59XA3D6");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC752KGJ2FXNZNYNPXRX");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC753TZGDVPGVPX5J0QJ");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75SHXC4K9XK3PFT0ZX");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75Y0ZD7NZ2VQAVFWJR");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC759NAK9KSKERT7TH7V");

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
    }
}
